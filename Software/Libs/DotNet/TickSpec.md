# TickSpec

A lightweight Behaviour Driven Development (BDD) framework for .NET that'll fit how you want to test. (https://github.com/fsprojects/TickSpec)

## How to create a specification project

1. Create an F# class library project.
2. Add the packages to the newly created project:
  - NUnit
  - NUnit3TestAdapter
  - FsUnit
  - TickSpec (**Note**: a .NET framework class library *requires* version 2.0.0-rc1 or later)
3. Add a `App.config` file to the project. Change the properties of the file to be like this image, ![App.config properties](./TickSpec-AppConfig-Properties.png)
4. Edit `App.config` to redirect bindings to `FSharp.Core` using the following section.
  ```
    <runtime>
        <assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1">
            <dependentAssembly>
                <assemblyIdentity name="FSharp.Core"
                                  publicKeyToken="b03f5f7f11d50a3a"
                                  culture="en-us" />
                <bindingRedirect oldVersion="0.0.0.0-4.5.0.0" newVersion="4.5.0.0" />
            </dependentAssembly>
        </assemblyBinding>
    </runtime>

  ```
3. Add .feature file specifying the feature, for example, ``Accounts.feature``.
4. Write the specification for the feature in ``Accounts.feature``.
5. Copy the [`NUnit` feature fixture file](https://github.com/fsprojects/TickSpec/blob/master/Examples/ByFramework/NUnit/FSharp.NUnit/FeatureFixture.fs) into the project.
6. Create a "Steps" file, for example, ``AccountsSteps.fs``.
7. Build the test project **manually**. (This step is required to **generate** the `NUnit` tests.)
8. Run the unit tests in the project. These tests **will** fail.
9. Write the step(s) indicated by the messages from the failing test run.
10. Repeat the previous three steps until all steps implemented.
11. Hopefully your tests pass, but better if they do not. :)
