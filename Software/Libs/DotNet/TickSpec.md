# TickSpec

A lightweight Behaviour Driven Development (BDD) framework for .NET that'll fit how you want to test. (https://github.com/fsprojects/TickSpec)

## How to create a specification project

1. Create an F# class library project.
2. Add the packages to the newly created project:
  - NUnit
  - NUnit3TestAdapter
  - FsUnit
  - TickSpec (**Note**: a .NET framework class library *requires* version 2.0.0-rc1 or later)
3. Add .feature file specifying the feature, for example, ``Accounts.feature``.
4. Write the specification for the feature in ``Accounts.feature``.
5. Copy the [`NUnit` feature fixture file](https://github.com/fsprojects/TickSpec/blob/master/Examples/ByFramework/NUnit/FSharp.NUnit/FeatureFixture.fs) into the project.
6. Build the test project **manually**. (This step is required to **generate** the `NUnit` tests.)
7. Run the unit tests in the project. These tests **will** fail.
8. Create a "Steps" file, for example, ``AccountsSteps.fs` The messages from the previous step will indicate the steps that have not yet been implemented.
9. Repeat steps 4 and 5 until all steps implemented.
10. Hopefully your tests pass, but better if they do not. :)
