using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class CaptionsDataParserValidator : MonoBehaviour
{
    public void ShowData(TextAsset textAsset) 
    {
        Queue<Caption> captionsQueue = new Queue<Caption>();

        CaptionDataParser captionsParser = new CaptionDataParser();

        captionsQueue = captionsParser.Parse(textAsset);

        if (captionsQueue == null) 
        {
            Debug.LogError($"Unable to parse <b>{textAsset.name}</b>.\n<i>Check the console for details.</i>");
            return;
        }

        Caption currentCaption;
        int captionIndex = 0;
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.AppendLine($"*** Data of <b>{textAsset.name}</b> ***");
        stringBuilder.AppendLine("");

        while (0 < captionsQueue.Count) 
        {
            currentCaption = captionsQueue.Dequeue();
            captionIndex++;

            stringBuilder.AppendLine($"<b>[{captionIndex}]</b>");
            stringBuilder.AppendLine($"<b>FirstRow:</b> { currentCaption.FirstRow}");
            stringBuilder.AppendLine($"<b>SecondRow:</b> {currentCaption.SecondRow}");
            stringBuilder.AppendLine($"<b>EntryTime:</b> {currentCaption.EntryTime}");
            stringBuilder.AppendLine($"<b>ExitTime:</b> {currentCaption.EntryTime}");
            stringBuilder.AppendLine("");
        }

        Debug.Log( stringBuilder.ToString() );
    }
}
