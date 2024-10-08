#### KSU SWE 3643:<br/>Software Testing and Quality Assurance<br/>Semester Project

[**Back to Project Overview**](README.md)

# Grading Rubric

#### Team Selection: 5%

-  5%: Team selection performed on time by submitting team information to the project spreadsheet including your teatm's public GitHub URL.

#### Source Control: 5%

-  5%: Git repository arranged per specification
   -  README.md in root
   -  .gitignore in root
   -  `/src` folder with all source code for four project modules

> [!WARNING] 
>
> Your project **must** be in your GitHub repository to be graded. Submissions via D2L, email, etc. will not be accepted.

#### Coding Standards: 5%

-  5%: All projects in the `/src` folder follow proper language conventions and structure

#### Documentation: 5%

-  5%: All documentation described in the specification is present, internally linked via a Table of Contents, contains the required material, and is grammatically correct. Important images, such as the architecture diagram, are visible - not just linked.

   Markdown is correctly formatted with headings, code blocks, relative links (where appropriate), images/screenshots, diagrams, etc.

#### Architecture: 10%

-  10%: The source is split into four modules - web app, calculator logic, unit tests, and end-to-end tests following your language's convention for arranging and referencing modules.

#### Calculator Logic: 15%

-  15%: All calculator methods are implemented and detect success and failure conditions as appropriate, returning a Results object to the client. Calculator logic is not split between the logic module and the UI module.

#### Calculator Unit Tests: 25%

-  2.5%: The unit test module references the calculator logic. Test logic and calculator logic are strictly separated between the unit test and calculator logic modules.
-  15%: All calculator methods have one or more related unit tests. All branches are tested, including success and failure paths. All unit tests follow the UnitOfWork_StateUnderTest_ExpectedBehavior naming convention from the specification and implement the AAA pattern.
-  7.5%: All calculator logic achieves 100% test coverage (as demonstrated in your IDE during your video demonstration). Coverage must test all logic, so carefully review code for 100% path coverage (including ternary conditions, if present).

#### Web Server App: 15%

-  5%: The web server app references the calculator logic. UI logic and calculator logic are strictly separated between the web app and the calculator logic module.
-  5%: The web server app can show error conditions returned from the logic module such as an empty list or a non-numeric value in a list or an improperly formed input line.
-  2.5%: The web server app implements a clear function to reset the app to the default state.
-  2.5%: The web server app's user interface, including layout, colors, and navigation, matches the specifications.

#### End-to-End Testing: 10%

-  2.5%: The end-to-end-test module does not directly reference the web server module (or the calculator logic and unit test modules). The end-to-end test module only references the web server module *via* the running server's URL.
-  7.5%: All end-to-end tests listed in the specification are written and operational. All end-to-end tests follow the method naming convention from the specification. 

#### Final Presentation: 5%

5% if complete, -25% penalty if not included

-  The video meets all specifications, including executing your application, unit tests, and end-to-end tests from a command line/terminal (you only demonstrate coverage from your IDE). The video is available on YouTube or Vimeo or is checked into your GitHub repository.

> [!WARNING]
>
> The video presentation has a minimal score value, but it is an important part of grading. If some or all of your project does not work, the video is your best method of demonstrating some mastery of the material and receiving partial credit. **Failure to submit the video will result in a penalty of 25%.**

#### Minimal Path to Success

You can achieve up to a 75% score on the project by completing all sections except the web server app and end-to-end testing.

- Team Selection 5%
- Source Control 5%
- Coding Standards 5%
- Documentation 5%
- Architecture 10%
- Calculator Logic 15%
- Calculator Logic Unit Tests 25%
- Final Presentation 5%
- Minimal Path Effort = 75%

If you choose to drop sections, be certain the sections you do submit are polished and demonstrate close adherence to the specifications. To achieve 75% on only the sections listed above, you must achieve a perfect score on each of those sections.

> [!WARNING]
>
> **Do not drop the video presentation. Failure to submit a video presentation will result in a 25% penalty.**

## Overall Grade Policy

**Your final course grade can only be one letter grade higher than your project.** If you do poorly on the project, you will do poorly overall.

