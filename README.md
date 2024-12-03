# Spaceship Game Upgrade: Scoring and Visual Enhancements

## Overview of Changes

1. **Scoring System**:
   - A scoring system was added to track the player's performance.
   - Scores increase as the player successfully eliminates enemies.

2. **Persistent Score Across Levels**:
   - A `GameManager` singleton was introduced to manage the score.
   - Scores are maintained across different levels using Unity's `DontDestroyOnLoad` mechanism.
   - When transitioning between scenes, the score persists, ensuring continuity for the player.

3. **Resetting Scores**:
   - The score resets to zero when restarting the game to provide a fresh experience.

4. **Graphical Enhancements**:
   - Updated the background of the "Game Over" scene to improve visual aesthetics.
   - Adjusted graphics in other scenes for a more polished look.

## How the Scoring System Works

- **Tracking Scores**: The `GameManager` script contains methods to add to the score (`AddScore`), reset it (`ResetScore`), and display it on the screen (`UpdateScoreText`).
- **Scene Management**: The score is saved and loaded using `PlayerPrefs` for smooth transitions.
- **UI Integration**: A `TextMeshPro` UI element dynamically updates to reflect the current score.

### Key Code Changes

1. **GameManager Script**:
   - The `GameManager` is a singleton that handles all score-related logic.
   - It uses `DontDestroyOnLoad` to ensure its persistence between scenes.
   - The `OnSceneLoaded` event is used to reassign the score UI reference when switching levels.

2. **Level Transition**:
   - Added logic to save the score before switching to a new level.
   - Ensured the score resets to zero only when starting a new game.

3. **Game Over Logic**:
   - Updated the "Game Over" screen to display the final score.
   - Enhanced visual design with a new background.

## How to Run the Project

1. Open the project in Unity.
2. Play the game from the main menu.
3. Progress through levels to see the score system in action.
4. Lose the game to view the "Game Over" screen and final score.

## Future Enhancements

- Add a high score system to track the best scores across sessions.
- Further refine the visuals for more immersive gameplay.

---

