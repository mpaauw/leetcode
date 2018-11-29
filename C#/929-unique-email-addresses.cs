public class Solution
{
    public int NumUniqueEmails(string[] emails)
    {
        var uniqueAddresses = new HashSet<string>();
        foreach(string email in emails)
        {
            var builder = new StringBuilder();
            var names = ParseNames(email);
            string domainName = names[1];
            string localName = CleanPlus(names[0]);
            localName = CleanDot(localName);

            builder.Append(localName);
            builder.Append('@');
            builder.Append(domainName);

            string modEmail = builder.ToString();
            if(!uniqueAddresses.Contains(modEmail))
            {
                uniqueAddresses.Add(modEmail);
            }
        }

        return uniqueAddresses.Count;
    }

    private string[] ParseNames(string email)
    {
        return email.Split('@');
    }

    private string CleanPlus(string localName)
    {
        var splitName = localName.Split('+');
        return splitName[0];
    }

    private string CleanDot(string localName)
    {
        return localName.Replace(".", "");
    }
}