# TickSpec

A lightweight Behaviour Driven Development (BDD) framework for .NET that'll fit how you want to test. (https://github.com/fsprojects/TickSpec)

## How to create a specification project

1. Create a unit test project.
2. Write a .feature file specifying the feature, for example, ``Accounts.feature``.
3. Copy the `NUnit` feature fixture file (https://github.com/fsprojects/TickSpec/blob/master/Examples/ByFramework/NUnit/FSharp.NUnit/FeatureFixture.fs) into the project.
4. Run the unit tests in the project. These tests **will** fail.
5. Create a "Steps" file, for example, ``AccountsSteps.fs` The messages from the previous step will indicate the steps that have not yet been implemented.
6. Repeat steps 4 and 5 until all steps implemented.
7. Hopefully your tests pass, but better if they do not. :)
