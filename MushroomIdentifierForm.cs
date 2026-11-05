using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Lab2App
{
    public partial class MushroomIdentifierForm : Form
    {
        // Decision Tree States:
        // State 0: Question 1 -> Convex cup?
        //   - YES -> State 1 (Forest?)
        //       - NO  -> Agaric Jaunissant (Leaf)
        //       - YES -> State 3 (Ring?)
        //           - YES -> Amanite tue-mouche (Leaf)
        //           - NO  -> Pied bleu (Leaf)
        //   - NO  -> State 2 (Gills?)
        //       - NO  -> Cepe de bordeau (Leaf)
        //       - YES -> State 4 (Forest?)
        //           - NO  -> Coprin chevelu (Leaf)
        //           - YES -> Girolle (Leaf)

        private int currentState = 0;
        private readonly List<string> history = new List<string>();

        public MushroomIdentifierForm()
        {
            InitializeComponent();
        }

        private void MushroomIdentifierForm_Load(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void ResetGame()
        {
            currentState = 0;
            history.Clear();

            pnlResultCard.Visible = false;
            btnYes.Enabled = true;
            btnNo.Enabled = true;

            UpdateQuestionUI();
            UpdateHistoryUI();
        }

        private void UpdateQuestionUI()
        {
            switch (currentState)
            {
                case 0:
                    lblStep.Text = "QUESTION 1 OF 3";
                    lblQuestionText.Text = "Does your mushroom have a convex cup?";
                    break;
                case 1:
                    lblStep.Text = "QUESTION 2 OF 3";
                    lblQuestionText.Text = "Does your mushroom grow in a forest?";
                    break;
                case 2:
                    lblStep.Text = "QUESTION 2 OF 3";
                    lblQuestionText.Text = "Does your mushroom have gills?";
                    break;
                case 3:
                    lblStep.Text = "QUESTION 3 OF 3";
                    lblQuestionText.Text = "Does your mushroom have a ring?";
                    break;
                case 4:
                    lblStep.Text = "QUESTION 3 OF 3";
                    lblQuestionText.Text = "Does your mushroom grow in a forest?";
                    break;
            }
        }

        private void UpdateHistoryUI()
        {
            if (history.Count == 0)
            {
                lblHistoryList.Text = "No questions answered yet. Start answering above!";
            }
            else
            {
                lblHistoryList.Text = string.Join(Environment.NewLine, history);
            }
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            HandleAnswer(true);
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            HandleAnswer(false);
        }

        private void HandleAnswer(bool isYes)
        {
            string answerText = isYes ? "Yes" : "No";

            switch (currentState)
            {
                case 0: // Q1: Convex cup
                    history.Add($"• Q1: Convex cup? -> {answerText}");
                    if (isYes)
                    {
                        currentState = 1;
                        UpdateQuestionUI();
                    }
                    else
                    {
                        currentState = 2;
                        UpdateQuestionUI();
                    }
                    break;

                case 1: // Q2A: Forest (Branch A)
                    history.Add($"• Q2: Grows in a forest? -> {answerText}");
                    if (!isYes)
                    {
                        ShowResult("Agaric Jaunissant", 2);
                    }
                    else
                    {
                        currentState = 3;
                        UpdateQuestionUI();
                    }
                    break;

                case 2: // Q2B: Gills (Branch B)
                    history.Add($"• Q2: Has gills? -> {answerText}");
                    if (!isYes)
                    {
                        ShowResult("Cepe de bordeau", 2);
                    }
                    else
                    {
                        currentState = 4;
                        UpdateQuestionUI();
                    }
                    break;

                case 3: // Q3A: Ring (Branch A2)
                    history.Add($"• Q3: Has a ring? -> {answerText}");
                    if (isYes)
                    {
                        ShowResult("Amanite tue-mouche", 3);
                    }
                    else
                    {
                        ShowResult("Pied bleu", 3);
                    }
                    break;

                case 4: // Q3B: Forest (Branch B2)
                    history.Add($"• Q3: Grows in a forest? -> {answerText}");
                    if (!isYes)
                    {
                        ShowResult("Coprin chevelu", 3);
                    }
                    else
                    {
                        ShowResult("Girolle", 3);
                    }
                    break;
            }

            UpdateHistoryUI();
        }

        private void ShowResult(string mushroomName, int questionCount)
        {
            btnYes.Enabled = false;
            btnNo.Enabled = false;

            lblMushroomName.Text = mushroomName;
            lblResultSummary.Text = $"Successfully identified in {questionCount} questions!";
            pnlResultCard.Visible = true;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
