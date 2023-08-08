using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}

namespace ColorSort
{
    public class colorSort
    {
        public string color { get; set; }
        public int count { get; set; }

        public colorSort(string color, int count)
        {
            this.color = color;
            this.count = count;
        }

        public override string ToString()
        {
            return color + " " + count;
        }

        public static List<colorSort> SortColors(List<colorSort> colors)
        {
            List<colorSort> sortedColors = new List<colorSort>();
            int count = 0;
            string color = "";
            foreach (colorSort c in colors)
            {
                if (c.color == color)
                {
                    count += c.count;
                }
                else
                {
                    if (color != "")
                    {
                        sortedColors.Add(new colorSort(color, count));
                    }
                    color = c.color;
                    count = c.count;
                }
            }
            sortedColors.Add(new colorSort(color, count));
            return sortedColors;
        }
    }
}
