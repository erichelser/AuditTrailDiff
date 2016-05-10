# AuditTrailDiff
Uses BeyondCompare to diff the changes listed in an IBM Ratioal ClearQuest "History and Audit Trail" tab.

Because IBM Rational ClearCase stores the "old" and "new" versions of altered fields in the same record, this makes it difficult to do a version-by-version comparison of what actually changed between revisions. This application uses BeyondCompare, a third-party diff tool, to make comparing ClearCase records more intuitive and user-friendly.

To use:
1. Enter the location of your BeyondCompare executable. Typically something like C:\Program Files\Beyond Compare 3\BCompare.exe. Quotes are not necessary.
2. Copy and paste the entire contents of the "History and Audit Trail" tab into the large text area.
3. Press Run Diff and wait for the BeyondCompare window to appear. Two text files will be generated in the same folder as the executable; these files are used by BeyondCompare to perform the comparison.
4. Press "Reset Field" to empty the contents of the text box.
