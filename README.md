# F# Mutable Variable Shadowing Bug

This repository demonstrates a common, yet subtle, bug in F# related to mutable variables and the shadowing of variables within functions.

The `bug.fs` file contains the erroneous code.  The `bugSolution.fs` provides a corrected version.  The issue arises from the unexpected modification of parameters within the `add` function, which leads to unintended consequences.