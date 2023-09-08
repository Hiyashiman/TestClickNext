using System;
namespace testClicknext.src
{
	public class ConvertSecondsToTime
	{
        public string secondsToTime(int totalSeconds)
        {
            int hours = totalSeconds / 3600;
            int minutes = (totalSeconds % 3600) / 60;
            int seconds = totalSeconds % 60;

            string formattedTime = string.Format("{0:D2}:{1:D2}:{2:D2}", hours, minutes, seconds);

            return formattedTime;
        }
    }
}

