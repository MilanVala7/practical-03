namespace Inheritance;

internal class Team: Sponsor
{
    private string teamName = "RCB";

    /// <summary>
    /// Purpose: Displays details of owner and sponsor of team.
    /// Return Type: string
    /// </summary>
    public string printInfo()
    {
        return "Owner: " + owner + ", Sponsor: " + teamName;
    }
}
