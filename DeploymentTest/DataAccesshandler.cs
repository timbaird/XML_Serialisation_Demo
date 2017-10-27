using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeploymentTest
{
    class DataAccesshandler
    {
        public static  string getXML()
        {
            string testData = @"<WidgetList>
                        <Widget>
                            <Name>Widget1</Name>
                            <Height>5</Height>
                            <Width>10</Width>
                        </Widget>
                        <Widget>
                            <Name>Widget2</Name>
                            <Height>50</Height>
                            <Width>100</Width>
                        </Widget>
                    </WidgetList>";

            return testData;
        }
    }
}
