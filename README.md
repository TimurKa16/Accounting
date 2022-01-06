# Accounting

2021 year

Before, I had an accounting paperbook. But it felt not systematized.
Therefore I develop a program.
It shows history, monthly payments and calculates debts.

I used DataGridView to draw tables and a database as a storage.

This time I was reading Martin Fowler's "Patterns of Enterprise Application Architecture".
So I dicided to divide a program into 2 parts: representation, logic and storage.
But representation and logic have merged together.

The Form.cs code became bigger, so I splitted partial class it into 2 files.
I got one trouble with that.
When I click on an element on the form, IDE created new handler (but this handler existed in the second file).
Thus, I found out that I should hold every IDE created handler in the first file.