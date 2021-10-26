# What is HimeDbg? 

HimeDbg is a quick and dirty Hime grammar editor and debugger. 

It allows you to:

* Edit a Hime grammar in a syntax-highlighting editor
* Compile the grammar
* Then enter a text in the target syntax and parse it
* And look at the tree 

Notes:

* It has never been designed to be an exemplar winforms app. It is what it is - a *quick and dirty* application to debug Hime grammars

* To find more information on Hime please check Hime's website and repo:
  
  https://cenotelie.fr/projects/hime

  https://github.com/cenotelie/hime

* If you are looking for a parser for the format in which the app copies an AST node into the clipboard, check it out here:
  
  https://github.com/nikolaygekht/luax/blob/24a10508be03a14f8f9567e586d804dbd1942871/Luax.Parser.Test/Utils/AstNodeExtensions.cs#L48