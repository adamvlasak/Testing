using System.Collections.Generic;
using System.Linq;

namespace UI.Core
{
    public static class LessonLinks
    {
        private static readonly List<Link> _links = new()
        {
            new Link { Title = "How to work with WebGoat", Id = 360466308, Score = 5, Parent = "Introduction" },
            new Link { Title = "How to create a Legacy Lesson", Id = 1894705151, Score = 5, Parent = "Introduction" },
            new Link { Title = "Http Basics", Id = 1869022003, Score = 100, Parent = "General" },
            new Link { Title = "Using an Access Control Matrix", Id = 1708534694, Score = 200, Parent = "Access Control Flaws" },
            new Link { Title = "Bypass a Path Based Access Control Scheme", Id = 231255157, Score = 200, Parent = "Access Control Flaws" },
            new Link { Title = "LAB: Role Based Access Control", Id = 160587164, Score = 200, Parent = "Access Control Flaws" },
            new Link { Title = "LAB: Client Side Filtering", Id = 330535848, Score = 400, Parent = "AJAX Security" },
            new Link { Title = "LAB: DOM-Based cross-site scripting", Id = 2022121558, Score = 400, Parent = "AJAX Security" },
            new Link { Title = "DOM Injection", Id = 76122667, Score = 400, Parent = "AJAX Security" },
            new Link { Title = "XML Injection", Id = 2000980640, Score = 400, Parent = "AJAX Security" },
            new Link { Title = "JSON Injection", Id = 1426618575, Score = 400, Parent = "AJAX Security" },
            new Link { Title = "Silent Transactions Attacks", Id = 218322538, Score = 400, Parent = "AJAX Security" },
            new Link { Title = "Dangerous Use of Eval", Id = 136634854, Score = 400, Parent = "AJAX Security" },
            new Link { Title = "Insecure Client Storage", Id = 1129417221, Score = 400, Parent = "AJAX Security" },
            new Link { Title = "Same Origin Policy Protection", Id = 1750680855, Score = 400, Parent = "AJAX Security" },
            new Link { Title = "Password Strength", Id = 1778575388, Score = 500, Parent = "Authentication Flaws" },
            new Link { Title = "Forgot Password", Id = 372049154, Score = 500, Parent = "Authentication Flaws" },
            new Link { Title = "Multi Level Login 2", Id = 810720180, Score = 500, Parent = "Authentication Flaws" },
            new Link { Title = "Multi Level Login 1", Id = 810720179, Score = 500, Parent = "Authentication Flaws" },
            new Link { Title = "Off-by-One Overflows", Id = 736032128, Score = 600, Parent = "Buffer Overflows" },
            new Link { Title = "Discover Clues in the HTML", Id = 125644239, Score = 700, Parent = "Code Quality" },
            new Link { Title = "Thread Safety Problems", Id = 339531107, Score = 800, Parent = "Concurrency" },
            new Link { Title = "Shopping Cart Concurrency Flaw", Id = 734491955, Score = 800, Parent = "Concurrency" },
            new Link { Title = "Phishing with XSS", Id = 1382523204, Score = 900, Parent = "Cross-Site Scripting (XSS)" },
            new Link { Title = "Stored XSS Attacks", Id = 598569451, Score = 900, Parent = "Cross-Site Scripting (XSS)" },
            new Link { Title = "LAB: Cross Site Scripting", Id = 611366032, Score = 900, Parent = "Cross-Site Scripting (XSS)" },
            new Link { Title = "Reflected XSS Attacks", Id = 1406352188, Score = 900, Parent = "Cross-Site Scripting (XSS)" },
            new Link { Title = "Cross Site Request Forgery (CSRF)", Id = 2078372, Score = 900, Parent = "Cross-Site Scripting (XSS)" },
            new Link { Title = "CSRF Prompt By-Pass", Id = 1471017872, Score = 900, Parent = "Cross-Site Scripting (XSS)" },
            new Link { Title = "CSRF Token By-Pass", Id = 803158781, Score = 900, Parent = "Cross-Site Scripting (XSS)" },
            new Link { Title = "HTTPOnly Test", Id = 68584332, Score = 900, Parent = "Cross-Site Scripting (XSS)" },
            new Link { Title = "Fail Open Authentication Scheme", Id = 1075773632, Score = 1000, Parent = "Improper Error Handling" },
            new Link { Title = "Command Injection", Id = 1922448916, Score = 1100, Parent = "Injection Flaws" },
            new Link { Title = "Numeric SQL Injection", Id = 101829144, Score = 1100, Parent = "Injection Flaws" },
            new Link { Title = "Log Spoofing", Id = 1572295549, Score = 1100, Parent = "Injection Flaws" },
            new Link { Title = "XPATH Injection", Id = 882451674, Score = 1100, Parent = "Injection Flaws" },
            new Link { Title = "LAB: SQL Injection", Id = 1537271095, Score = 1100, Parent = "Injection Flaws" },
            new Link { Title = "String SQL Injection", Id = 538385464, Score = 1100, Parent = "Injection Flaws" },
            new Link { Title = "Database Backdoors ", Id = 980912706, Score = 1100, Parent = "Injection Flaws" },
            new Link { Title = "Blind Numeric SQL Injection", Id = 586116895, Score = 1100, Parent = "Injection Flaws" },
            new Link { Title = "Blind String SQL Injection", Id = 1315528047, Score = 1100, Parent = "Injection Flaws" },
            new Link { Title = "ZipBomb", Id = 1382524227, Score = 1200, Parent = "Denial of Service" },
            new Link { Title = "Denial of Service from Multiple Logins", Id = 1036971378, Score = 1200, Parent = "Denial of Service" },
            new Link { Title = "Insecure Login", Id = 1525997619, Score = 1300, Parent = "Insecure Communication" },
            new Link { Title = "Encoding Basics", Id = 1786050421, Score = 1500, Parent = "Insecure Storage" },
            new Link { Title = "Malicious File Execution", Id = 2027530490, Score = 1600, Parent = "Malicious Execution" },
            new Link { Title = "Bypass HTML Field Restrictions", Id = 82558034, Score = 1700, Parent = "Parameter Tampering" },
            new Link { Title = "XML External Entity (XXE)", Id = 87365, Score = 1700, Parent = "Parameter Tampering" },
            new Link { Title = "Exploit Hidden Fields", Id = 1863884331, Score = 1700, Parent = "Parameter Tampering" },
            new Link { Title = "Exploit Unchecked Email", Id = 1584137874, Score = 1700, Parent = "Parameter Tampering" },
            new Link { Title = "Bypass Client Side JavaScript Validation", Id = 1574219258, Score = 1700, Parent = "Parameter Tampering" },
            new Link { Title = "Hijack a Session", Id = 950261113, Score = 1800, Parent = "Session Management Flaws" },
            new Link { Title = "Spoof an Authentication Cookie", Id = 1212175692, Score = 1800, Parent = "Session Management Flaws" },
            new Link { Title = "Session Fixation", Id = 2007866518, Score = 1800, Parent = "Session Management Flaws" },
            new Link { Title = "Create a SOAP Request", Id = 1995914340, Score = 1900, Parent = "Web Services" },
            new Link { Title = "WSDL Scanning", Id = 1708497611, Score = 1900, Parent = "Web Services" },
            new Link { Title = "Web Service SQL Injection", Id = 1319172155, Score = 1900, Parent = "Web Services" },
            new Link { Title = "Web Service SAX Injection", Id = 1329550039, Score = 1900, Parent = "Web Services" },
            new Link { Title = "Lesson information", Id = 1307234977, Score = 2000, Parent = "Admin Functions" },
            new Link { Title = "Summary Report Card", Id = 1903127658, Score = 2000, Parent = "Admin Functions" },
            new Link { Title = "Refresh Database", Id = 543941051, Score = 2000, Parent = "Admin Functions" },
            new Link { Title = "Product Information", Id = 478695543, Score = 2000, Parent = "Admin Functions" },
            new Link { Title = "User Information", Id = 415330224, Score = 2000, Parent = "Admin Functions" },
            new Link { Title = "Adhoc Query", Id = 1657245536, Score = 2000, Parent = "Admin Functions" },
            new Link { Title = "Report Card", Id = 1904549904, Score = 2000, Parent = "Admin Functions" },
            new Link { Title = "The CHALLENGE", Id = 162777743, Score = 3000, Parent = "Challenge" }
        };

        public static Link GetLinkByText(string text)
        {
            return _links.Single(l => l.Title == text);
        }

        public static Link GetLinkByUrl(string url)
        {
            return _links.Single(l => l.Path == url);
        }

        public static Link GetById(int id)
        {
            return _links.Single(l => l.Id == id);
        }
    }
}
