using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePhunWithStrings
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 1.  Reverse your name
            string name = "Bob Tabor";
			// In my case, the result would be:
			// robaT boB

			for (int i = name.Length - 1; i >= 0; i--)
			{
				resultLabel.Text += name[i];
			}

            // 2.  Reverse this sequence:
            string names = "Luke,Leia,Han,Chewbacca";
			// When you're finished it should look like this:
			// Chewbacca,Han,Leia,Luke

			/*string[] starWars = names.Split(',');
			string result = "";
			for (int i = starWars.Length - 1; i >= 0; i--)
			{
				result += starWars[i] + ", ";
			}
			result = result.Remove(result.Length - 2, 1);
			resultLabel.Text = result;
			*/

			// 3. Use the sequence to create ascii art:
			// *****luke*****
			// *****leia*****
			// *****han******
			// **Chewbacca***
			/*
			string[] starWars = names.Split(',');
			string result = "";
			for (int i = 0; i < starWars.Length; i++)
			{
				int padLeft = (14 - starWars[i].Length) / 2;
				string temp = starWars[i].PadLeft(starWars[i].Length + padLeft, '*');
				result += temp.PadRight(14, '*');
				result += "<br />";
			}

			resultLabel.Text = result;
			*/

			// 4. Solve this puzzle:

			string puzzle = "NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN ZO COME ZO ZHE AID OF ZHEIR COUNZRY.";

			// Once you fix it with string helper methods, it should read:
			// Now is the time for all good men to come to the aid of their country.
			string delete = "remove-me";
			int index = puzzle.IndexOf(delete);
			puzzle = puzzle.Remove(index, delete.Length);
			puzzle = puzzle.ToLower();
			puzzle = puzzle.Replace('z', 't');
			puzzle = puzzle.Remove(0, 1);
			puzzle = puzzle.Insert(0, "N");
			resultLabel.Text = puzzle;
        }
    }
}