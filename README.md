SpyGameDesktopApplication Documentation
1. Introduction
1.1 Project Overview
SpyGameDesktopApplication is a desktop-based software that provides an engaging and interactive environment for players to participate in a spy-themed game. The application is designed as a part of the Software Engineering 2 course and demonstrates the integration of object-oriented principles, usability, and game mechanics.

1.2 Purpose and Scope
The purpose of this project is to offer an immersive spy game where players take on different roles and interact in a structured environment. It is designed for both educational and entertainment purposes, highlighting concepts like player management, game state transitions, and GUI interactions.

1.3 Features
Player management with customizable avatars.
Random word selection and spy detection mechanics.
Interactive graphical user interface (GUI) for a seamless gaming experience.
Score tracking and leaderboard functionalities.
2. System Design
2.1 UML Diagrams
Class Diagram:

plantuml
Copy code
@startuml
class GameData {
  +List<string> words
  +List<Player> Players
  +List<int> asker
  +List<int> answerer
  +int TheCurrentPlayerindex
  +int SpyIndex
  +string ChoosenWord
  +void PreparePlayersList()
  +void AddPlayer(Player player)
  -void SwapInArray<T>(List<T> array, int index1, int index2)
  -void Shuffle(List<int> list)
}

class Player {
  +string Name
  +int Score
  +Image Avatar
}

class KnowYourStateForm {
  +void nextPageBtn_Click(object sender, EventArgs e)
}

GameData "1" *-- "n" Player
KnowYourStateForm ..> GameData
@enduml
Use Case Diagram:

plantuml
Copy code
@startuml
actor Player
rectangle Game {
  usecase "Start Game" as UC1
  usecase "Select Avatar" as UC2
  usecase "Play Round" as UC3
  usecase "View Scores" as UC4
}
Player -- UC1
Player -- UC2
Player -- UC3
Player -- UC4
@enduml
Sequence Diagram for Preparing Players List:

plantuml
Copy code
@startuml
actor User
participant GameData
User -> GameData: PreparePlayersList()
GameData -> GameData: AddPlayer()
GameData -> GameData: Shuffle(asker)
GameData -> GameData: Shuffle(answerer)
GameData -> GameData: Assign SpyIndex
GameData -> GameData: Choose Word
@enduml
Activity Diagram for Game Flow:

plantuml
Copy code
@startuml
start
:Initialize Game;
:Prepare Players List;
:Assign Roles;
repeat
  :Player Asks Question;
  :Player Answers Question;
  :Update Game State;
repeat while (Game Not Over?)
:Determine Winner;
stop
@enduml
2.2 Architecture Overview
The application follows a modular architecture:

Game Logic Module: Handles game rules, state transitions, and spy selection.
UI Module: Manages user interface components, including forms and panels.
Data Module: Maintains player data, words, and configurations.
3. Implementation
3.1 Code Structure
Namespace: SpyGamev1._0Csharp
Modules:
GameData: Manages players, words, and game logic.
Player: Represents individual players.
KnowYourStateForm: Handles the game's state transitions.
3.2 Key Components
Player Class: Represents individual players with attributes like Name, Score, and Avatar.
GameData Class: Provides utility methods for preparing the game state and managing player interactions.
Forms: Implements the graphical user interface.
3.3 Running the Application
Clone the repository: git clone https://github.com/kiritoALGO/SpyGameDesktopApplication
Open the project in Visual Studio.
Build and run the application.
4. Project Management
4.1 Cost Estimation
The cost estimation is based on the COCOMO model:

Estimated Lines of Code (LOC): ~1,500 LOC
Development Effort (Person-Months): 2.4
Development Time (Months): 5.6
Average Staffing (Persons): 0.43
Assumptions:

Project Type: Organic
Effort Multipliers: Nominal values
4.2 Complexity
Cyclomatic Complexity: Measures the number of linearly independent paths through the program's source code.
GameData.PreparePlayersList(): Complexity = 5
GameData.Shuffle(List<int> list): Complexity = 3
GameData.AddPlayer(Player player): Complexity = 1
4.3 Function Points
Unadjusted Function Count (UFC):

External Inputs (EI): 5
External Outputs (EO): 3
External Inquiries (EQ): 2
Internal Logical Files (ILF): 4
External Interface Files (EIF): 1
Complexity Weights:

EI: 3
EO: 4
EQ: 3
ILF: 7
EIF: 5
Unadjusted Function Points (UFP):

UFP = (53) + (34) + (23) + (47) + (1*5) = 15 + 12 + 6 + 28 + 5 = 66
Value Adjustment Factor (VAF):

Total Degree of Influence (DI): 30 (Assumed)
VAF = 0.65 + (0.01 * DI) = 0.65 + 0.3 = 0.95
Adjusted Function Points (AFP):

AFP = UFP * VAF = 66 * 0.95 = 62.7
5. Testing
5.1 Test Cases
Test Case ID	Description	Expected Outcome	Status
TC01	Verify player addition	Players list updated	Pass
TC02	Validate spy assignment	SpyIndex is unique	Pass
TC03	Check word selection	ChoosenWord is from list	Pass
TC04	Shuffle functionality	Lists are randomized	Pass
TC05	UI responsiveness	Forms load correctly	Pass
5.2 Test Strategy
Unit Testing: For individual classes and methods.
Integration Testing: Verifying interactions between modules.
System Testing: Ensuring the complete system functions as intended.
User Acceptance Testing (UAT): Validating the application with end-users.
6. Maintenance

Sources
