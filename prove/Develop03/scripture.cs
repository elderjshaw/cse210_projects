/* 
Memorization Program
CSE210
Word Program
Joshua Moncada, David Ertel
(c)2023
*/


using System;
using System.Collections.Generic;

public class Scripture

// Set Variables
{
    public List<Scripture> JMscripture = new List<Scripture>();
    private string JMproName = "collection.txt";
    private string JMitem;
    private string JMtext;
    public int JMkey;
    public string JMscriptText;


//Entries set options
    public void LoadScriptures()
    {
        List<string> readText = File.ReadAllLines(JMproName).Where(arg => !string.IsNullOrWhiteSpace(arg)).ToList();

        foreach (string line in readText)
        {
            string[] entries = line.Split(";");

            Scripture entry = new Scripture();

            entry.JMitem = entries[0];
            entry.JMtext = entries[6];

            JMscripture.Add(entry);
        }
    }
    public void ScriptureDisplay()
    {
        foreach (Scripture item in JMscripture)
        {
            item.ShowScripture();
        }
    }
    public void ShowScripture()
    {
        Console.WriteLine($"\n{JMtext}");
    }

    public int GetRandomIndex()
    {
        var random = new Random();
        JMkey = random.Next(JMscripture.Count);
        return JMkey;
    }

    public string RandomScripture()
    {
        JMkey = GetRandomIndex();
       return JMscriptText = JMscripture[JMkey].JMtext;
    }

    public void HideWords()
    {
        Word DEshown = new Word();
        DEshown.visibility(JMscripture);
    }


    public void GetRenderedText()
    {

    }
    public void IsCompletelyHidden()
    {

    }

    public void Referring()
    {
        Reference info = new Reference();
        info.refer();
    }


}