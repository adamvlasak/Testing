using System.Collections.Generic;
using System.Linq;

namespace WebGoat.Data
{
    public static class LessonLinks
    {
        public static List<Link> Links = new List<Link>()
        {
            new Link { Title = "How to work with WebGoat", Id = 360466308, Path = "/start.mvc#attack/360466308/5", Score = 5, Parent = "Introduction" },
            new Link { Title = "How to create a Legacy Lesson", Id = 1894705151, Path = "/start.mvc#attack/1894705151/5", Score = 5, Parent = "Introduction" },
            new Link { Title = "Http Basics", Id = 1869022003, Path = "/start.mvc#attack/1869022003/100", Score = 100, Parent = "General" },
            new Link { Title = "Using an Access Control Matrix", Id = 1708534694, Path = "/start.mvc#attack/1708534694/200", Score = 200, Parent = "Access Control Flaws" },
            new Link { Title = "Bypass a Path Based Access Control Scheme", Id = 231255157, Path = "/start.mvc#attack/231255157/200", Score = 200, Parent = "Access Control Flaws" },
            new Link { Title = "LAB: Role Based Access Control", Id = 160587164, Path = "/start.mvc#attack/160587164/200", Score = 200, Parent = "Access Control Flaws" },
            new Link { Title = "LAB: Client Side Filtering", Id = 330535848, Path = "/start.mvc#attack/330535848/400", Score = 400, Parent = "AJAX Security" },
            new Link { Title = "LAB: DOM-Based cross-site scripting", Id = 2022121558, Path = "/start.mvc#attack/2022121558/400", Score = 400, Parent = "AJAX Security" },
            new Link { Title = "DOM Injection", Id = 76122667, Path = "/start.mvc#attack/76122667/400", Score = 400, Parent = "AJAX Security" },
            new Link { Title = "XML Injection", Id = 2000980640, Path = "/start.mvc#attack/2000980640/400", Score = 400, Parent = "AJAX Security" },
            new Link { Title = "JSON Injection", Id = 1426618575, Path = "/start.mvc#attack/1426618575/400", Score = 400, Parent = "AJAX Security" },
            new Link { Title = "Silent Transactions Attacks", Id = 218322538, Path = "/start.mvc#attack/218322538/400", Score = 400, Parent = "AJAX Security" },
            new Link { Title = "Dangerous Use of Eval", Id = 136634854, Path = "/start.mvc#attack/136634854/400", Score = 400, Parent = "AJAX Security" },
            new Link { Title = "Insecure Client Storage", Id = 1129417221, Path = "/start.mvc#attack/1129417221/400", Score = 400, Parent = "AJAX Security" },
            new Link { Title = "Same Origin Policy Protection", Id = 1750680855, Path = "/start.mvc#attack/1750680855/400", Score = 400, Parent = "AJAX Security" },
            new Link { Title = "Password Strength", Id = 1778575388, Path = "/start.mvc#attack/1778575388/500", Score = 500, Parent = "Authentication Flaws" },
            new Link { Title = "Forgot Password", Id = 372049154, Path = "/start.mvc#attack/372049154/500", Score = 500, Parent = "Authentication Flaws" },
            new Link { Title = "Multi Level Login 2", Id = 810720180, Path = "/start.mvc#attack/810720180/500", Score = 500, Parent = "Authentication Flaws" },
            new Link { Title = "Multi Level Login 1", Id = 810720179, Path = "/start.mvc#attack/810720179/500", Score = 500, Parent = "Authentication Flaws" },
            new Link { Title = "Off-by-One Overflows", Id = 736032128, Path = "/start.mvc#attack/736032128/600", Score = 600, Parent = "Buffer Overflows" },
            new Link { Title = "Discover Clues in the HTML", Id = 125644239, Path = "/start.mvc#attack/125644239/700", Score = 700, Parent = "Code Quality" },
            new Link { Title = "Thread Safety Problems", Id = 339531107, Path = "/start.mvc#attack/339531107/800", Score = 800, Parent = "Concurrency" },
            new Link { Title = "Shopping Cart Concurrency Flaw", Id = 734491955, Path = "/start.mvc#attack/734491955/800", Score = 800, Parent = "Concurrency" },
            new Link { Title = "Phishing with XSS", Id = 1382523204, Path = "/start.mvc#attack/1382523204/900", Score = 900, Parent = "Cross-Site Scripting (XSS)" },
            new Link { Title = "Stored XSS Attacks", Id = 598569451, Path = "/start.mvc#attack/598569451/900", Score = 900, Parent = "Cross-Site Scripting (XSS)" },
            new Link { Title = "LAB: Cross Site Scripting", Id = 611366032, Path = "/start.mvc#attack/611366032/900", Score = 900, Parent = "Cross-Site Scripting (XSS)" },
            new Link { Title = "Reflected XSS Attacks", Id = 1406352188, Path = "/start.mvc#attack/1406352188/900", Score = 900, Parent = "Cross-Site Scripting (XSS)" },
            new Link { Title = "Cross Site Request Forgery (CSRF)", Id = 2078372, Path = "/start.mvc#attack/2078372/900", Score = 900, Parent = "Cross-Site Scripting (XSS)" },
            new Link { Title = "CSRF Prompt By-Pass", Id = 1471017872, Path = "/start.mvc#attack/1471017872/900", Score = 900, Parent = "Cross-Site Scripting (XSS)" },
            new Link { Title = "CSRF Token By-Pass", Id = 803158781, Path = "/start.mvc#attack/803158781/900", Score = 900, Parent = "Cross-Site Scripting (XSS)" },
            new Link { Title = "HTTPOnly Test", Id = 68584332, Path = "/start.mvc#attack/68584332/900", Score = 900, Parent = "Cross-Site Scripting (XSS)" },
            new Link { Title = "Fail Open Authentication Scheme", Id = 1075773632, Path = "/start.mvc#attack/1075773632/1000", Score = 1000, Parent = "Improper Error Handling" },
            new Link { Title = "Command Injection", Id = 1922448916, Path = "/start.mvc#attack/1922448916/1100", Score = 1100, Parent = "Injection Flaws" },
            new Link { Title = "Numeric SQL Injection", Id = 101829144, Path = "/start.mvc#attack/101829144/1100", Score = 1100, Parent = "Injection Flaws" },
            new Link { Title = "Log Spoofing", Id = 1572295549, Path = "/start.mvc#attack/1572295549/1100", Score = 1100, Parent = "Injection Flaws" },
            new Link { Title = "XPATH Injection", Id = 882451674, Path = "/start.mvc#attack/882451674/1100", Score = 1100, Parent = "Injection Flaws" },
            new Link { Title = "LAB: SQL Injection", Id = 1537271095, Path = "/start.mvc#attack/1537271095/1100", Score = 1100, Parent = "Injection Flaws" },
            new Link { Title = "String SQL Injection", Id = 538385464, Path = "/start.mvc#attack/538385464/1100", Score = 1100, Parent = "Injection Flaws" },
            new Link { Title = "Database Backdoors ", Id = 980912706, Path = "/start.mvc#attack/980912706/1100", Score = 1100, Parent = "Injection Flaws" },
            new Link { Title = "Blind Numeric SQL Injection", Id = 586116895, Path = "/start.mvc#attack/586116895/1100", Score = 1100, Parent = "Injection Flaws" },
            new Link { Title = "Blind String SQL Injection", Id = 1315528047, Path = "/start.mvc#attack/1315528047/1100", Score = 1100, Parent = "Injection Flaws" },
            new Link { Title = "ZipBomb", Id = 1382524227, Path = "/start.mvc#attack/1382524227/1200", Score = 1200, Parent = "Denial of Service" },
            new Link { Title = "Denial of Service from Multiple Logins", Id = 1036971378, Path = "/start.mvc#attack/1036971378/1200", Score = 1200, Parent = "Denial of Service" },
            new Link { Title = "Insecure Login", Id = 1525997619, Path = "/start.mvc#attack/1525997619/1300", Score = 1300, Parent = "Insecure Communication" },
            new Link { Title = "Encoding Basics", Id = 1786050421, Path = "/start.mvc#attack/1786050421/1500", Score = 1500, Parent = "Insecure Storage" },
            new Link { Title = "Malicious File Execution", Id = 2027530490, Path = "/start.mvc#attack/2027530490/1600", Score = 1600, Parent = "Malicious Execution" },
            new Link { Title = "Bypass HTML Field Restrictions", Id = 82558034, Path = "/start.mvc#attack/82558034/1700", Score = 1700, Parent = "Parameter Tampering" },
            new Link { Title = "XML External Entity (XXE)", Id = 87365, Path = "/start.mvc#attack/87365/1700", Score = 1700, Parent = "Parameter Tampering" },
            new Link { Title = "Exploit Hidden Fields", Id = 1863884331, Path = "/start.mvc#attack/1863884331/1700", Score = 1700, Parent = "Parameter Tampering" },
            new Link { Title = "Exploit Unchecked Email", Id = 1584137874, Path = "/start.mvc#attack/1584137874/1700", Score = 1700, Parent = "Parameter Tampering" },
            new Link { Title = "Bypass Client Side JavaScript Validation", Id = 1574219258, Path = "/start.mvc#attack/1574219258/1700", Score = 1700, Parent = "Parameter Tampering" },
            new Link { Title = "Hijack a Session", Id = 950261113, Path = "/start.mvc#attack/950261113/1800", Score = 1800, Parent = "Session Management Flaws" },
            new Link { Title = "Spoof an Authentication Cookie", Id = 1212175692, Path = "/start.mvc#attack/1212175692/1800", Score = 1800, Parent = "Session Management Flaws" },
            new Link { Title = "Session Fixation", Id = 2007866518, Path = "/start.mvc#attack/2007866518/1800", Score = 1800, Parent = "Session Management Flaws" },
            new Link { Title = "Create a SOAP Request", Id = 1995914340, Path = "/start.mvc#attack/1995914340/1900", Score = 1900, Parent = "Web Services" },
            new Link { Title = "WSDL Scanning", Id = 1708497611, Path = "/start.mvc#attack/1708497611/1900", Score = 1900, Parent = "Web Services" },
            new Link { Title = "Web Service SQL Injection", Id = 1319172155, Path = "/start.mvc#attack/1319172155/1900", Score = 1900, Parent = "Web Services" },
            new Link { Title = "Web Service SAX Injection", Id = 1329550039, Path = "/start.mvc#attack/1329550039/1900", Score = 1900, Parent = "Web Services" },
            new Link { Title = "Lesson information", Id = 1307234977, Path = "/start.mvc#attack/1307234977/2000", Score = 2000, Parent = "Admin Functions" },
            new Link { Title = "Summary Report Card", Id = 1903127658, Path = "/start.mvc#attack/1903127658/2000", Score = 2000, Parent = "Admin Functions" },
            new Link { Title = "Refresh Database", Id = 543941051, Path = "/start.mvc#attack/543941051/2000", Score = 2000, Parent = "Admin Functions" },
            new Link { Title = "Product Information", Id = 478695543, Path = "/start.mvc#attack/478695543/2000", Score = 2000, Parent = "Admin Functions" },
            new Link { Title = "User Information", Id = 415330224, Path = "/start.mvc#attack/415330224/2000", Score = 2000, Parent = "Admin Functions" },
            new Link { Title = "Adhoc Query", Id = 1657245536, Path = "/start.mvc#attack/1657245536/2000", Score = 2000, Parent = "Admin Functions" },
            new Link { Title = "Report Card", Id = 1904549904, Path = "/start.mvc#attack/1904549904/2000", Score = 2000, Parent = "Admin Functions" },
            new Link { Title = "The CHALLENGE", Id = 162777743, Path = "/start.mvc#attack/162777743/3000", Score = 3000, Parent = "Challenge" }
        };

        public static Link GetLinkByText(string text)
        {
            return Links.Where(l => l.Title == text).Single();
        }

        public static Link GetLinkByUrl(string url)
        {
            return Links.Where(l => l.Path == url).Single();
        }

        public static Link GetById(int id)
        {
            return Links.Where(l => l.Id == id).Single();
        }
    }
}
