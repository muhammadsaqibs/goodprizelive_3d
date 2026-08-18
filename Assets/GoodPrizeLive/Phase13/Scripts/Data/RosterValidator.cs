using UnityEngine;

public static class RosterValidator
{
    public static bool IsValid(string category, int totalMembersIncludingCaptain)
    {
        if (category == "Girls") return totalMembersIncludingCaptain == 12;
        if (category == "Men") return totalMembersIncludingCaptain == 16;
        return false;
    }
}
