using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace aspnetcoreapp.Pages
{
    public class AboutModel : PageModel
    {
        private readonly ILogger<AboutModel> _logger;

        public AboutModel(ILogger<AboutModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            if (Request.Method.Equals("POST", System.StringComparison.OrdinalIgnoreCase))
            {
                try
                {
                    double num1 = 0;
                    double num2 = 0;

                    // Parse num1 if it's not empty
                    if (!string.IsNullOrEmpty(Request.Form["num1"]))
                    {
                        num1 = double.Parse(Request.Form["num1"]);
                    }

                    // Parse num2 if it's not empty
                    if (!string.IsNullOrEmpty(Request.Form["num2"]))
                    {
                        num2 = double.Parse(Request.Form["num2"]);
                    }

                    if (Request.Form["ADD"] == "ADD")
                    {
                        ViewData["sum"] = num1 + num2;
                    }

                    if (Request.Form["SQR"] == "SQR")
                    {
                        if (!string.IsNullOrEmpty(Request.Form["num1"]))
                        {
                            ViewData["squares"] = $"Square of {num1}: {num1 * num1}";
                        }
                        if (!string.IsNullOrEmpty(Request.Form["num2"]))
                        {
                            ViewData["squares"] += (ViewData["squares"] != null ? ", " : "") + $"Square of {num2}: {num2 * num2}";
                        }
                    }

                    if (Request.Form["POW"] == "POW")
                    {
                        if (!string.IsNullOrEmpty(Request.Form["num1"]) && !string.IsNullOrEmpty(Request.Form["num2"]))
                        {
                            ViewData["power"] = Math.Pow(num1, num2);
                        }
                        else
                        {
                            ViewData["error"] = "Both numbers are required for power operation.";
                        }
                    }

                    if (Request.Form["Multiply"] == "Multiply")
                    {
                        ViewData["multiply"] = num1 * num2;
                    }

                    if (Request.Form["Subtraction"] == "Subtraction")
                    {
                        ViewData["subtrct"] = num1 - num2;
                    }

                    if (Request.Form["Division"] == "Division")
                    {
                        if (num2 != 0)
                        {
                            ViewData["division"] = num1 / num2;
                        }
                        else
                        {
                            ViewData["division"] = "Error: Cannot divide by zero";
                        }
                    }

                    if (Request.Form["Cube"] == "Cube")
                    {
                        if (!string.IsNullOrEmpty(Request.Form["num1"]))
                        {
                            ViewData["cube"] = $"Cube of {num1}: {Math.Pow(num1, 3)}";
                        }
                        if (!string.IsNullOrEmpty(Request.Form["num2"]))
                        {
                            ViewData["cube"] += (ViewData["cube"] != null ? ", " : "") + $"Cube of {num2}: {Math.Pow(num2, 3)}";
                        }
                    }
                }
                catch (FormatException)
                {
                    ViewData["error"] = "Please enter valid numbers.";
                }
            }
        }
    }
}
