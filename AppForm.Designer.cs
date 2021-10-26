namespace himedbg
{
    partial class AppForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonFindNext = new System.Windows.Forms.Button();
            this.buttonFind = new System.Windows.Forms.Button();
            this.buttonReload = new System.Windows.Forms.Button();
            this.buttonSaveAs = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonCompileGrammar = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.scintilla = new ScintillaNET.Scintilla();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxTest = new System.Windows.Forms.TextBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPageAST = new System.Windows.Forms.TabPage();
            this.treeViewAST = new System.Windows.Forms.TreeView();
            this.tabPageTestErrors = new System.Windows.Forms.TabPage();
            this.listBoxTestErrors = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonFindInTree = new System.Windows.Forms.Button();
            this.buttonCopyAstNode = new System.Windows.Forms.Button();
            this.checkBoxReduceTree = new System.Windows.Forms.CheckBox();
            this.buttonCompileTest = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPageAST.SuspendLayout();
            this.tabPageTestErrors.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1691, 757);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1683, 728);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Grammar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.scintilla, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.listBox1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1677, 722);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonFindNext);
            this.panel1.Controls.Add(this.buttonFind);
            this.panel1.Controls.Add(this.buttonReload);
            this.panel1.Controls.Add(this.buttonSaveAs);
            this.panel1.Controls.Add(this.buttonLoad);
            this.panel1.Controls.Add(this.buttonCompileGrammar);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1671, 24);
            this.panel1.TabIndex = 0;
            // 
            // buttonFindNext
            // 
            this.buttonFindNext.Location = new System.Drawing.Point(615, 0);
            this.buttonFindNext.Name = "buttonFindNext";
            this.buttonFindNext.Size = new System.Drawing.Size(133, 23);
            this.buttonFindNext.TabIndex = 6;
            this.buttonFindNext.Text = "Find Next (^F)";
            this.buttonFindNext.UseVisualStyleBackColor = true;
            this.buttonFindNext.Click += new System.EventHandler(this.buttonFindNext_Click);
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(501, 0);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(108, 23);
            this.buttonFind.TabIndex = 5;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // buttonReload
            // 
            this.buttonReload.Location = new System.Drawing.Point(387, 0);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(108, 23);
            this.buttonReload.TabIndex = 4;
            this.buttonReload.Text = "Reload (^R)";
            this.buttonReload.UseVisualStyleBackColor = true;
            this.buttonReload.Click += new System.EventHandler(this.buttonReload_Click);
            // 
            // buttonSaveAs
            // 
            this.buttonSaveAs.Location = new System.Drawing.Point(184, 1);
            this.buttonSaveAs.Name = "buttonSaveAs";
            this.buttonSaveAs.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveAs.TabIndex = 3;
            this.buttonSaveAs.Text = "Save As";
            this.buttonSaveAs.UseVisualStyleBackColor = true;
            this.buttonSaveAs.Click += new System.EventHandler(this.buttonSaveAs_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(3, 0);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 0;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonCompileGrammar
            // 
            this.buttonCompileGrammar.Location = new System.Drawing.Point(265, 0);
            this.buttonCompileGrammar.Name = "buttonCompileGrammar";
            this.buttonCompileGrammar.Size = new System.Drawing.Size(116, 23);
            this.buttonCompileGrammar.TabIndex = 2;
            this.buttonCompileGrammar.Text = "Compile (^Q)";
            this.buttonCompileGrammar.UseVisualStyleBackColor = true;
            this.buttonCompileGrammar.Click += new System.EventHandler(this.buttonCompileGrammar_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(84, 0);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(94, 23);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save (^S)";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // scintilla
            // 
            this.scintilla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scintilla.Location = new System.Drawing.Point(3, 33);
            this.scintilla.Name = "scintilla";
            this.scintilla.Size = new System.Drawing.Size(1671, 536);
            this.scintilla.TabIndex = 1;
            this.scintilla.InsertCheck += new System.EventHandler<ScintillaNET.InsertCheckEventArgs>(this.scintilla_InsertCheck);
            this.scintilla.UpdateUI += new System.EventHandler<ScintillaNET.UpdateUIEventArgs>(this.scintilla_UpdateUI);
            this.scintilla.Click += new System.EventHandler(this.scintilla_Click);
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(3, 575);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1671, 144);
            this.listBox1.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1683, 728);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Test";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.textBoxTest, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tabControl2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1677, 722);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // textBoxTest
            // 
            this.textBoxTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTest.Font = new System.Drawing.Font("Consolas", 9.969231F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTest.Location = new System.Drawing.Point(3, 33);
            this.textBoxTest.Multiline = true;
            this.textBoxTest.Name = "textBoxTest";
            this.textBoxTest.Size = new System.Drawing.Size(1671, 340);
            this.textBoxTest.TabIndex = 1;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPageAST);
            this.tabControl2.Controls.Add(this.tabPageTestErrors);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(3, 379);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1671, 340);
            this.tabControl2.TabIndex = 2;
            // 
            // tabPageAST
            // 
            this.tabPageAST.Controls.Add(this.treeViewAST);
            this.tabPageAST.Location = new System.Drawing.Point(4, 25);
            this.tabPageAST.Name = "tabPageAST";
            this.tabPageAST.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAST.Size = new System.Drawing.Size(1663, 311);
            this.tabPageAST.TabIndex = 0;
            this.tabPageAST.Text = "AST";
            this.tabPageAST.UseVisualStyleBackColor = true;
            // 
            // treeViewAST
            // 
            this.treeViewAST.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewAST.HideSelection = false;
            this.treeViewAST.Location = new System.Drawing.Point(3, 3);
            this.treeViewAST.Name = "treeViewAST";
            this.treeViewAST.Size = new System.Drawing.Size(1657, 305);
            this.treeViewAST.TabIndex = 0;
            // 
            // tabPageTestErrors
            // 
            this.tabPageTestErrors.Controls.Add(this.listBoxTestErrors);
            this.tabPageTestErrors.Location = new System.Drawing.Point(4, 25);
            this.tabPageTestErrors.Name = "tabPageTestErrors";
            this.tabPageTestErrors.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTestErrors.Size = new System.Drawing.Size(1663, 311);
            this.tabPageTestErrors.TabIndex = 1;
            this.tabPageTestErrors.Text = "Errors";
            this.tabPageTestErrors.UseVisualStyleBackColor = true;
            // 
            // listBoxTestErrors
            // 
            this.listBoxTestErrors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxTestErrors.FormattingEnabled = true;
            this.listBoxTestErrors.ItemHeight = 16;
            this.listBoxTestErrors.Location = new System.Drawing.Point(3, 3);
            this.listBoxTestErrors.Name = "listBoxTestErrors";
            this.listBoxTestErrors.Size = new System.Drawing.Size(1657, 305);
            this.listBoxTestErrors.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonFindInTree);
            this.panel2.Controls.Add(this.buttonCopyAstNode);
            this.panel2.Controls.Add(this.checkBoxReduceTree);
            this.panel2.Controls.Add(this.buttonCompileTest);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1671, 24);
            this.panel2.TabIndex = 3;
            // 
            // buttonFindInTree
            // 
            this.buttonFindInTree.Location = new System.Drawing.Point(454, 0);
            this.buttonFindInTree.Name = "buttonFindInTree";
            this.buttonFindInTree.Size = new System.Drawing.Size(174, 23);
            this.buttonFindInTree.TabIndex = 3;
            this.buttonFindInTree.Text = "Find Sel In Tree (^T)";
            this.buttonFindInTree.UseVisualStyleBackColor = true;
            this.buttonFindInTree.Click += new System.EventHandler(this.buttonFindInTree_Click);
            // 
            // buttonCopyAstNode
            // 
            this.buttonCopyAstNode.Location = new System.Drawing.Point(284, 0);
            this.buttonCopyAstNode.Name = "buttonCopyAstNode";
            this.buttonCopyAstNode.Size = new System.Drawing.Size(164, 23);
            this.buttonCopyAstNode.TabIndex = 2;
            this.buttonCopyAstNode.Text = "Copy AST Node (^N)";
            this.buttonCopyAstNode.UseVisualStyleBackColor = true;
            this.buttonCopyAstNode.Click += new System.EventHandler(this.buttonCopyAstNode_Click);
            // 
            // checkBoxReduceTree
            // 
            this.checkBoxReduceTree.AutoSize = true;
            this.checkBoxReduceTree.Location = new System.Drawing.Point(134, 2);
            this.checkBoxReduceTree.Name = "checkBoxReduceTree";
            this.checkBoxReduceTree.Size = new System.Drawing.Size(144, 21);
            this.checkBoxReduceTree.TabIndex = 1;
            this.checkBoxReduceTree.Text = "Reduce AST Tree";
            this.checkBoxReduceTree.UseVisualStyleBackColor = true;
            // 
            // buttonCompileTest
            // 
            this.buttonCompileTest.Location = new System.Drawing.Point(2, 0);
            this.buttonCompileTest.Name = "buttonCompileTest";
            this.buttonCompileTest.Size = new System.Drawing.Size(110, 23);
            this.buttonCompileTest.TabIndex = 0;
            this.buttonCompileTest.Text = "Compile (^W)";
            this.buttonCompileTest.UseVisualStyleBackColor = true;
            this.buttonCompileTest.Click += new System.EventHandler(this.buttonCompileTest_Click);
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1691, 757);
            this.Controls.Add(this.tabControl1);
            this.KeyPreview = true;
            this.Name = "AppForm";
            this.Text = "HimeDbg";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPageAST.ResumeLayout(false);
            this.tabPageTestErrors.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonCompileGrammar;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private ScintillaNET.Scintilla scintilla;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonSaveAs;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox textBoxTest;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPageAST;
        private System.Windows.Forms.TreeView treeViewAST;
        private System.Windows.Forms.TabPage tabPageTestErrors;
        private System.Windows.Forms.ListBox listBoxTestErrors;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox checkBoxReduceTree;
        private System.Windows.Forms.Button buttonCompileTest;
        private System.Windows.Forms.Button buttonCopyAstNode;
        private System.Windows.Forms.Button buttonReload;
        private System.Windows.Forms.Button buttonFindNext;
        private System.Windows.Forms.Button buttonFind;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonFindInTree;
    }
}

