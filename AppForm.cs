using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hime.Redist;
using Hime.Redist.Parsers;
using Hime.Redist.Utils;
using Hime.SDK;
using Hime.SDK.Output;
using Hime.SDK.Reflection;
using ScintillaNET;

namespace himedbg
{
    public partial class AppForm : Form
    {
        public AppForm()
        {
            InitializeComponent();
            InitializeScintilla();
            this.Text = "HimeDbg: New Grammar";
            buttonCompileTest.Enabled = false;
        }

        void InitializeScintilla()
        {
            scintilla.StyleResetDefault();
            scintilla.Styles[Style.Default].Font = "Consolas";
            scintilla.Styles[Style.Default].Size = 10;
            scintilla.StyleClearAll();
            
            scintilla.Styles[Style.Cpp.Comment].ForeColor = Color.FromArgb(128, 128, 128);
            scintilla.Styles[Style.Cpp.Character].ForeColor = Color.FromArgb(0, 0, 128);
            scintilla.Styles[Style.Cpp.String].ForeColor = Color.FromArgb(0, 0, 128);
            scintilla.Styles[Style.Cpp.Word].ForeColor = Color.FromArgb(0, 128, 0);
            scintilla.Styles[Style.Cpp.Operator].ForeColor = Color.FromArgb(0, 192, 0);

            scintilla.Styles[Style.BraceLight].ForeColor = Color.FromArgb(0, 192, 0);
            scintilla.Styles[Style.BraceBad].ForeColor = Color.FromArgb(128, 0, 0);

            scintilla.Lexer = Lexer.Cpp;
            scintilla.SetProperty("fold", "1");
            scintilla.SetProperty("fold.compact", "1");
            scintilla.Margins[2].Type = MarginType.Symbol;
            scintilla.Margins[2].Mask = Marker.MaskFolders;
            scintilla.Margins[2].Sensitive = true;
            scintilla.Margins[2].Width = 20;

            // Set colors for all folding markers
            for (int i = 25; i <= 31; i++)
            {
                scintilla.Markers[i].SetForeColor(SystemColors.ControlLightLight);
                scintilla.Markers[i].SetBackColor(SystemColors.ControlDark);
            }

            // Configure folding markers with respective symbols
            scintilla.Markers[Marker.Folder].Symbol = MarkerSymbol.BoxPlus;
            scintilla.Markers[Marker.FolderOpen].Symbol = MarkerSymbol.BoxMinus;
            scintilla.Markers[Marker.FolderEnd].Symbol = MarkerSymbol.BoxPlusConnected;
            scintilla.Markers[Marker.FolderMidTail].Symbol = MarkerSymbol.TCorner;
            scintilla.Markers[Marker.FolderOpenMid].Symbol = MarkerSymbol.BoxMinusConnected;
            scintilla.Markers[Marker.FolderSub].Symbol = MarkerSymbol.VLine;
            scintilla.Markers[Marker.FolderTail].Symbol = MarkerSymbol.LCorner;

            // Enable automatic folding
            scintilla.AutomaticFold = (AutomaticFold.Show | AutomaticFold.Click | AutomaticFold.Change);
          
            scintilla.SetKeywords(0, "grammar options terminals rules");

            scintilla.AssignCmdKey(Keys.Control | Keys.F, Command.Null);
        }

        private static bool IsBrace(int c)
        {
            switch (c)
            {
                case '(':
                case ')':
                case '[':
                case ']':
                case '{':
                case '}':
                    return true;
            }
            return false;
        }

        private int lastCaretPos = 0;

        private void scintilla_UpdateUI(object sender, UpdateUIEventArgs e)
        {
            // Has the caret changed position?
            int caretPos = scintilla.CurrentPosition;
            if (lastCaretPos != caretPos)
            {
                lastCaretPos = caretPos;
                var bracePos1 = -1;
                var bracePos2 = -1;

                // Is there a brace to the left or right?
                if (caretPos > 0 && IsBrace(scintilla.GetCharAt(caretPos - 1)))
                    bracePos1 = (caretPos - 1);
                else if (IsBrace(scintilla.GetCharAt(caretPos)))
                    bracePos1 = caretPos;

                if (bracePos1 >= 0)
                {
                    // Find the matching brace
                    bracePos2 = scintilla.BraceMatch(bracePos1);
                    if (bracePos2 == Scintilla.InvalidPosition)
                    {
                        scintilla.BraceBadLight(bracePos1);
                        scintilla.HighlightGuide = 0;
                    }
                    else
                    {
                        scintilla.BraceHighlight(bracePos1, bracePos2);
                        scintilla.HighlightGuide = scintilla.GetColumn(bracePos1);
                    }
                }
                else
                {
                    // Turn off brace matching
                    scintilla.BraceHighlight(Scintilla.InvalidPosition, Scintilla.InvalidPosition);
                    scintilla.HighlightGuide = 0;
                }
            }
        }

        private void scintilla_Click(object sender, EventArgs e)
        {

        }

        private string mFileName = null;

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.CheckFileExists = true;
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                scintilla.Text = File.ReadAllText(dlg.FileName);
                mFileName = dlg.FileName;
                this.Text = $"HimeDbg: [{mFileName}]";
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (mFileName == null)
                buttonSaveAs_Click(sender, e);

            File.WriteAllText(mFileName, scintilla.Text);
        }

        private void buttonSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.CheckPathExists = true;
            dlg.OverwritePrompt = true;
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                mFileName = dlg.FileName;
                File.WriteAllText(mFileName, scintilla.Text);
                this.Text = $"HimeDbg: [{mFileName}]";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private string GetGrammarName(string text)
        {
            Regex re = new Regex(@"grammar\s*(\w+)[\s\n]*\{");
            Match m = re.Match(text);
            if (m.Success)
                return m.Groups[1].Value;
            return null;
        }

        private AssemblyReflectionEx mPreviousCompilationResult;
        
        private void buttonCompileGrammar_Click(object sender, EventArgs e)
        {
            buttonCompileTest.Enabled = false;
            listBox1.Items.Clear();
            listBox1.Items.Add($"{DateTime.Now}: Compilation Started");

            if (mPreviousCompilationResult != null)
                mPreviousCompilationResult = null;

            string text = scintilla.Text;
            string grammarName = GetGrammarName(text);
            string tempPath = Path.GetTempPath();

            if (grammarName == null)
            {
                listBox1.Items.Add($"Grammar name is not found");
                return;
            }

            CompilationTask task = new CompilationTask();
            task.AddInputRaw(grammarName, new StringReader(scintilla.Text));
            task.CodeAccess = Modifier.Internal;
            task.GrammarName = grammarName;
            task.Mode = Mode.Assembly;
            task.OutputPath = tempPath;
            task.Namespace = "HimeDbg.Generated";
            Report report = task.Execute();          

            if (report.Errors.Count == 0)
                listBox1.Items.Add($"Compilation of grammar {(grammarName ?? "Unknown")} has been completed successfully!");
            else
            {
                listBox1.Items.Add($"Compilation failed with {report.Errors.Count} errors!");
                foreach (var error in report.Errors)
                    listBox1.Items.Add(error.ToString());

                return;
            }

            string assemblyFile = Path.Combine(tempPath, $"{grammarName}.dll");

            if (!CheckAtReportError(assemblyFile))
                return;

            mPreviousCompilationResult = new AssemblyReflectionEx(assemblyFile);
            buttonCompileTest.Enabled = true;
        }

        private bool CheckAtReportError(string file)
        {
            if (!File.Exists(file))
            {
                listBox1.Items.Add($"Compilation result {file} is not found");
                return false;
            }
            return true;
        }

        private void buttonCompileTest_Click(object sender, EventArgs e)
        {
            treeViewAST.Nodes.Clear();
            listBoxTestErrors.Items.Clear();

            ROList<Type> parsers = mPreviousCompilationResult.Parsers;
            if (parsers.Count != 1)
                MessageBox.Show("More than one parser is found");
            BaseLRParser parser = mPreviousCompilationResult.GetParser(parsers[0], textBoxTest.Text);
            ParseResult parsingResult = parser.Parse();
            if (parsingResult.IsSuccess)
            {
                Type ids = parsers[0].GetNestedTypes().First(t => t.Name == "ID");
                tabControl2.SelectedTab = tabPageAST;
                ASTNode root = parsingResult.Root;
                TreeNode rootNode = treeViewAST.Nodes.Add(ToString(root, ids, textBoxTest.Text));
                rootNode.Tag = root;
                ScanNode(rootNode, root, checkBoxReduceTree.Checked, ids, textBoxTest.Text);
            }
            else
            {
                tabPageTestErrors.Select();
                tabControl2.SelectedTab = tabPageTestErrors;
                foreach (ParseError error in parsingResult.Errors)
                    listBoxTestErrors.Items.Add(error.ToString());
            }
        }

        private void ScanNode(TreeNode parentTreeNode, ASTNode parentAstNode, bool reduceTree = false, Type ids = null, string text = null)
        {
            foreach (ASTNode astNode in parentAstNode.Children)
            {
                if (string.IsNullOrEmpty(astNode.Value) && astNode.Children.Count == 1 && reduceTree)
                {
                    ScanNode(parentTreeNode, astNode, reduceTree, ids, text);
                }
                else
                {
                    TreeNode treeNode = parentTreeNode.Nodes.Add(ToString(astNode, ids, text));
                    treeNode.Tag = astNode;
                    ScanNode(treeNode, astNode, reduceTree, ids, text);
                }
            }
        }

        private static string ToString(ASTNode node, Type ids, string source)
        {
            string idName = "??";
            if (ids != null)
            {
                var props = ids.GetFields(BindingFlags.Static | BindingFlags.Public);
                foreach (var prop in props)
                {
                    if (prop.FieldType == typeof(int) && (int)prop.GetValue(null) == node.Symbol.ID)
                        idName = prop.Name;
                }
            }

            string src = "";
            
            if (source != null && node.Span.Length > 0)
                src = source.Substring(node.Span.Index, node.Span.Length);
            if (src.Length > 32)
                src = src.Substring(0, 32) + "...";

            return $"{node.Symbol.Name} [{node.Value ?? null}] {idName} := {src} @ {node.Position.Line}, {node.Position.Column}";
        }

        private static void ToString1(ASTNode node, StringBuilder sb)
        {
            sb.Append("[");
            sb.Append(node.Symbol.Name);
            if (!string.IsNullOrEmpty(node.Value))
                sb.Append('(').Append(node.Value).Append(')');
            for (int i = 0; i < node.Children.Count; i++)
                ToString1(node.Children[i], sb);
            sb.Append("]");
        }

        private void buttonCopyAstNode_Click(object sender, EventArgs e)
        {
            if (treeViewAST.SelectedNode != null && treeViewAST.SelectedNode.Tag is ASTNode node)
            {
                StringBuilder sb = new StringBuilder();
                ToString1(node, sb);
                Clipboard.SetText(sb.ToString());
                MessageBox.Show($"Node string presentation is in clipboard\r\n" + sb.ToString());
            }
            else
                MessageBox.Show("No tree node associated with AST node is selected");
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mFileName) || !File.Exists(mFileName))
                buttonLoad_Click(sender, e);
            else
                scintilla.Text = File.ReadAllText(mFileName);
        }

        private string mTextToSearch = "";
        private int mLastFind = 0;

        private void DoSearch()
        {
            scintilla.TargetStart = mLastFind;
            scintilla.TargetEnd = scintilla.TextLength;
            var rc = scintilla.SearchInTarget(mTextToSearch);
            if (rc < 0)
                MessageBox.Show("The text is not found");
            else
            {
                scintilla.SelectionStart = rc;
                scintilla.SelectionEnd = rc;
                mLastFind = rc + mTextToSearch.Length;
                scintilla.ScrollCaret();
                if (!scintilla.Focused)
                    scintilla.Focus();
            }
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            FindForm dlg = new FindForm();
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                mTextToSearch = dlg.TextToSearch;
                mLastFind = 0;
                DoSearch();
            }
        }

        private void buttonFindNext_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mTextToSearch))
                buttonFind_Click(sender, e);
            else
                DoSearch();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F && e.Control && !e.Alt && !e.Shift)
            {
                buttonFindNext_Click(sender, e);
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.S && e.Control && !e.Alt && !e.Shift)
            {
                buttonSave_Click(sender, e);
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.R && e.Control && !e.Alt && !e.Shift)
            {
                buttonReload_Click(sender, e);
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Q && e.Control && !e.Alt && !e.Shift)
            {
                buttonCompileGrammar_Click(sender, e);
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.W && e.Control && !e.Alt && !e.Shift)
            {
                buttonCompileTest_Click(sender, e);
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.N && e.Control && !e.Alt && !e.Shift)
            {
                buttonCopyAstNode_Click(sender, e);
                e.Handled = true;
            }
        }

        private void scintilla_InsertCheck(object sender, InsertCheckEventArgs e)
        {
            if (e.Text.Length == 1 && e.Text[0] < ' ')
                e.Text = "";
        }

        private void ScanForNode(int line, int column, TreeNodeCollection nodes, ref ASTNode? candidate, ref TreeNode treeNode)
        {
            for (int i = 0; i < nodes.Count; i++)
            {
                if (nodes[i].Tag != null && nodes[i].Tag is ASTNode)
                {
                    var node = (ASTNode)nodes[i].Tag;
                    if (node.Position.Line == line && node.Position.Column <= column)
                    {
                        if (candidate == null || candidate.Value.Position.Column < node.Position.Column)
                        {
                            treeNode = nodes[i];
                            candidate = node;
                        }
                    }
                }
                if (nodes[i].Nodes.Count > 0)
                    ScanForNode(line, column, nodes[i].Nodes, ref candidate, ref treeNode);
            }
        }

        private void buttonFindInTree_Click(object sender, EventArgs e)
        {
            var position = textBoxTest.SelectionStart;
            var line = textBoxTest.GetLineFromCharIndex(position);
            var column = position - textBoxTest.GetFirstCharIndexFromLine(line);

            ASTNode? candidate = null;
            TreeNode treeNode = null;
            ScanForNode(line + 1, column + 1, treeViewAST.Nodes, ref candidate, ref treeNode);
            if (treeNode != null)
                treeViewAST.SelectedNode = treeNode;
        }
    }
}
