# WordTableConverter
A Visual C# Windows Forms Application that extracts data from selected columns of an imported Word document, then injects the data into selected columns from another empty table in another document.
Requires Microsoft Word to work.

*Current version needs additional feature implementation for larger tables*

## Tutorial
Let's say we have a table of Data (Content/DataExample.docx)
![DataExample.docx](/README_CONTENT/1.PNG)

And another table that serves as a template (Content/TableExample.docx)
![TableExample.docx](/README_CONTENT/2.PNG)

Follow the following steps:

1-Run the program, select DataExample.docx for the source document and TableExample.docx for the target document.
Now enter in "Match rows with__columns" the number of columns the table has. In our case, it's 3 and 2.
![Step 1](/README_CONTENT/3.PNG)

2-Select which columns from the source document to inject into the target document.
In our case, 3 will be injected into 1, and 1 will be injected to 2. 
![Step 2](/README_CONTENT/4.PNG)

3-Optionally modify font and text size of data
![Step 3](/README_CONTENT/5.PNG)

4-Press Save and choose a destination file.

Here's our result:

![Result](/README_CONTENT/6.PNG)
