1. Create a winforms application with a form and 2 listboxes(IstColors Uppercase and IstColors Lowercase) placed horizontally.

II. Add a class Rainbow that has an array of string representing the 7 colors in the rainbow.

III. Implement the IEnumerable interface on the rainbow class and yield return the colors using a for loop.

IV. In the load event of the form, create an instance of Rainbow class. Create a reference of type IEnumerator

and assign it an enumerator by calling the rainbow object's GetEnumerator() method. Add the current item to IstColorsUppercase listbox by converting the item to an uppercase string within a while loop that uses the enumerator.