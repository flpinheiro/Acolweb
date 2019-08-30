using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int maximun;
        string ret = "";

        try
        {
            maximun = int.Parse(Max.Text);
        }
        catch (FormatException)
        {
            maximun = 0;
        }
        catch (ArgumentNullException)
        {
            maximun = 0;
        }
        catch (OverflowException)
        {
            maximun = 0;
        }

        if (maximun > 0)
        {
            int i = 1;
            while (i <= maximun)
            {
                ret += "<div class='row'>";
                for (int j = 0; j < 5 && i <= maximun; j++, i++)
                {
                    
                    if (i % 2 == 0)
                    {   
                        ret += "<div class='col-2 tabuada'>";
                    }
                    else
                    {
                        ret += "<div class='col-2 tabuada colored'>";
                    }

                    for (int k = 0; k < 11; k++)
                    {

                        ret += $"<p>{i} X {k} = {i * k}</p>";
                    }
                    
                    ret += "</div>";
                }
                ret += "</div>";
            }
        }
        Tabuada.Text = ret;
    }
}