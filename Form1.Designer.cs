using System.Media;
namespace NavigationOfSoltrianius;

public static class BackgroundMusic
{
    private static SoundPlayer player = null;
    private static string musicFilePath = @"Assets\Nov2025_Sound Game Jam_Intro_TravisBernauMusic.wav";

    public static void StartMusic()
    {
        if (System.IO.File.Exists(musicFilePath))
        {

            player = new SoundPlayer(musicFilePath);
            player.PlayLooping();
            System.Diagnostics.Debug.WriteLine("Background music started.");
        }
    }
    public static void StopMusic()
    {
        if (player != null)
        {
            player.Stop();
            player.Dispose();
            player = null;
        }
    }
}

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region 

    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(1000, 1000);
        this.Text = "Form1";

        // Add a button to proceed
        Button startButton = new Button();
        startButton.Text = "Start";
        startButton.Location = new System.Drawing.Point(900, 600);
        startButton.Size = new System.Drawing.Size(100, 50);
        startButton.Click += startButton_Click;
        this.Controls.Add(startButton);

        //Title Screen Background
        // Load image from file but also, @"File's Relative Path Here" format is the best for loading images!
        Image titleBackground = Image.FromFile(@"Assets\SoltrianiusRevisedTitleScreen.png");
        // Set the background image
        this.BackgroundImage = titleBackground;
        // Adjust layout so image scales with form
        this.BackgroundImageLayout = ImageLayout.Stretch;
    }

    private void startButton_Click(object sender, EventArgs e)
    {
        storyScene1 storyStart = new storyScene1();
        storyStart.Show();
        this.Hide();
    }

    public class storyScene1 : Form
    {
        public storyScene1()
        {
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            Image scene1 = Image.FromFile(@"Assets\NavigationOfSoltrianiusStoryPart1.png");
            this.BackgroundImage = scene1;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            // Add a button to proceed
            Button storyPart2 = new Button();
            storyPart2.Text = "Proceed ->";
            storyPart2.Location = new System.Drawing.Point(900, 625);
            storyPart2.Size = new System.Drawing.Size(150, 50);
            storyPart2.Click += storyPart2_Click;
            this.Controls.Add(storyPart2);
        }

        private void storyPart2_Click(object sender, EventArgs e)
        {
            storyScene2 storyPart2 = new storyScene2();
            storyPart2.Show();
            this.Hide();
        }
    }


    public class storyScene2 : Form
    {
        public storyScene2()
        {
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            Image scene2 = Image.FromFile(@"Assets\NavigationOfSoltrianiusStoryPart2.png");
            this.BackgroundImage = scene2;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            // Add a button to proceed
            Button storyPart3 = new Button();
            storyPart3.Text = "Proceed ->";
            storyPart3.Location = new System.Drawing.Point(900, 625);
            storyPart3.Size = new System.Drawing.Size(150, 50);
            storyPart3.Click += storyPart3_Click;
            this.Controls.Add(storyPart3);
        }
        private void storyPart3_Click(object sender, EventArgs e)
        {
            storyScene3 storyPart3 = new storyScene3();
            storyPart3.Show();
            this.Hide();
        }
    }

    public class storyScene3 : Form
    {
        public storyScene3()
        {
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            Image scene3 = Image.FromFile(@"Assets\NavigationOfSoltrianiusStoryPart3.png");
            this.BackgroundImage = scene3;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            // Add a button to proceed
            Button storyPart4 = new Button();
            storyPart4.Text = "Proceed ->";
            storyPart4.Location = new System.Drawing.Point(900, 625);
            storyPart4.Size = new System.Drawing.Size(150, 50);
            storyPart4.Click += storyPart4_Click;
            this.Controls.Add(storyPart4);
        }
        private void storyPart4_Click(object sender, EventArgs e)
        {
            storyScene4 storyPart4 = new storyScene4();
            storyPart4.Show();
            this.Hide();
        }
    }

    public class storyScene4 : Form
    {
        public storyScene4()
        {
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            Image scene4 = Image.FromFile(@"Assets\NavigationOfSoltrianiusStoryPart4.png");
            this.BackgroundImage = scene4;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            // Add a button to proceed
            Button storyPart5 = new Button();
            storyPart5.Text = "Proceed ->";
            storyPart5.Location = new System.Drawing.Point(900, 625);
            storyPart5.Size = new System.Drawing.Size(150, 50);
            storyPart5.Click += storyPart5_Click;
            this.Controls.Add(storyPart5);
        }
        private void storyPart5_Click(object sender, EventArgs e)
        {
            storyScene5 storyPart5 = new storyScene5();
            storyPart5.Show();
            this.Hide();
        }
    }

    public class storyScene5 : Form
    {
        public storyScene5()
        {
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            Image scene5 = Image.FromFile(@"Assets\NavigationOfSoltrianiusStoryPart5.png");
            this.BackgroundImage = scene5;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            // Add a button to proceed
            Button gameStart = new Button();
            gameStart.Text = "Proceed ->";
            gameStart.Location = new System.Drawing.Point(900, 625);
            gameStart.Size = new System.Drawing.Size(150, 50);
            gameStart.Click += gameStart_Click;
            this.Controls.Add(gameStart);
        }
        //This method is the scene transition from the Start Screen to the In-Game Board
        private void gameStart_Click(object sender, EventArgs e)
        {
            // Opens the Game after clicking the button
            inGame mainForm = new inGame();
            mainForm.Show(); //Shows the Game on Screen
            this.Hide(); //Hides the Game on Screen
        }
    }

    public class inGame : Form
    {
        public inGame()
        {
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Navigation of Soltrianius";
            this.Size = new Size(800, 600);
            this.StartPosition = FormStartPosition.CenterScreen;

            //In Game Background
            Image gameBackground = Image.FromFile(@"Assets\SoltrianiusGameBoard.png");
            this.BackgroundImage = gameBackground;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            //Pause Button
            Button pauseButton = new Button();
            pauseButton.Size = new Size(100, 100);
            pauseButton.Location = new Point(1700, 100);
            pauseButton.Image = Image.FromFile(@"Assets\SoltrianiusPauseButton.jpeg");
            pauseButton.Padding = new Padding(0);
            // Makes the button borderless to look like just an icon
            pauseButton.FlatStyle = FlatStyle.Flat;
            pauseButton.FlatAppearance.BorderSize = 0;
            pauseButton.BackColor = Color.Transparent;
            pauseButton.Click += pauseButton_Click;
            this.Controls.Add(pauseButton);
        }
        private void pauseButton_Click(object sender, EventArgs e)
        {
            // Opens the Game after clicking the button
            pauseMenu menu = new pauseMenu();
            menu.Show();
            this.Hide();
        }
    }

    public class pauseMenu : Form
    {
        public pauseMenu()
        {
            this.Text = "Navigation of Soltrianius";
            this.Size = new Size(800, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            //Pause Background
            Image gameBackground = Image.FromFile(@"Assets\SoltrianiusInGameBackground.jpeg");
            this.BackgroundImage = gameBackground;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            //Back to Game Button
            Button backToGameButton = new Button();
            backToGameButton.Text = "Back to Game";
            backToGameButton.Location = new System.Drawing.Point(900, 200);
            backToGameButton.Size = new System.Drawing.Size(150, 50);
            backToGameButton.Click += backToGameButton_Click;
            this.Controls.Add(backToGameButton);

            //Reference Card Button
            Button referenceCardButton = new Button();
            referenceCardButton.Text = "Go to Reference Guide";
            referenceCardButton.Location = new System.Drawing.Point(900, 500);
            referenceCardButton.Size = new System.Drawing.Size(200, 50);
            referenceCardButton.Click += referenceCardButton_Click;
            this.Controls.Add(referenceCardButton);

            //Exit Button
            Button backToTitleButton = new Button();
            backToTitleButton.Text = "Back to Title";
            backToTitleButton.Location = new System.Drawing.Point(900, 800);
            backToTitleButton.Size = new System.Drawing.Size(150, 50);
            backToTitleButton.Click += backToTitleButton_Click;
            this.Controls.Add(backToTitleButton);
        }
        private void backToGameButton_Click(object sender, EventArgs e)
        {
            // Opens the Game after clicking the button
            inGame board = new inGame();
            board.Show(); //Shows the Game on Screen
            this.Hide(); //Hides the Game on Screen
        }
        private void referenceCardButton_Click(object sender, EventArgs e)
        {
            // Opens the Game after clicking the button
            referenceCard guide = new referenceCard();
            guide.Show(); //Shows the Game on Screen
            this.Hide(); //Hides the Game on Screen
        }

        private void backToTitleButton_Click(object sender, EventArgs e)
        {
            // Opens the Game after clicking the button
            Form1 mainForm = new Form1();
            mainForm.Show(); //Shows the Game on Screen
            this.Hide(); //Hides the Game on Screen
        }

    }

    /// <summary>
    /// referenceCard is used to show the UI of the guide and tips for playing Navigation of Soltrianius.
    /// </summary>
    public class referenceCard : Form
    {
        /// <summary>
        /// referenceCard() is the constructor method holding the UI of the guide.
        /// </summary>
        public referenceCard()
        {
            this.Text = "Navigation of Soltrianius";
            this.Size = new Size(800, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            Image gameBackground = Image.FromFile(@"Assets\SoltrianiusGuideCard.png");
            this.BackgroundImage = gameBackground;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            //Back to Game Button
            Button backToGame = new Button();
            backToGame.Text = "Back to Game";
            backToGame.Location = new System.Drawing.Point(925, 900);
            backToGame.Size = new System.Drawing.Size(150, 50);
            backToGame.Click += backToGame_Click;
            this.Controls.Add(backToGame);
        }

        /// <summary>
        /// backToGame_Click() is used to perform the action of swapping from the guide screen to the game.
        /// </summary>
        /// <param name="sender">Represents the event listener for the button.</param>
        /// <param name="e">Represents the arguments for the event of the button's press.</param>
        private void backToGame_Click(object sender, EventArgs e)
        {
            // Opens the Game after clicking the button
            inGame board = new inGame();
            board.Show(); //Shows the Game on Screen
            this.Hide(); //Hides the Game on Screen
        }

    }

    #endregion
}
