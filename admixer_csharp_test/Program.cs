uint color = 1;
uint[] hedgehogs = [3, 0, 12];

int CountMeetings(uint color, uint[] hedgehogs)
{
    int stepsNumber = 0;
    var targetColor = hedgehogs[color];
    var otherColors = hedgehogs.Where((_, index) => index != color).Order().ToArray();
    if (otherColors[0] == otherColors[1])
        return (int)otherColors[0];
    if (Math.Abs((int)otherColors[0] - otherColors[1]) % 3 != 0 || Math.Min(otherColors[0], otherColors[1]) == 0)
        return -1;
    while(otherColors[0] != otherColors[1])
    {
        if (targetColor - 1 >= 0)  
        {
            targetColor--;           
            otherColors[0] += 2;     
            otherColors[1]--;        
        }
        else
        {
            targetColor += 2;        
            otherColors[0]--;        
            otherColors[1]--;        
        }
        stepsNumber++;
    }
   return stepsNumber + (int)otherColors[0];
}
var result = CountMeetings(color,hedgehogs);
Console.WriteLine(result);