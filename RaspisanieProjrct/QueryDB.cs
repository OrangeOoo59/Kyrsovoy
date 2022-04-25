using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaspisanieProjrct
{
    static public class QueryDB
    {
        readonly static public Dictionary<string, string> Query = new Dictionary<string, string>()
        {

            ["RomeWeek"] = "select name_rome_week from tableWeek order by name_rome_week",
            ["DayWeek"] = "select name_day from tableDayWeek",
            ["AbbrevGroup"] = "select abbrev_group from tableGroup order by abbrev_group",
            ["Professor"] = "select name_professor from tableProfessor order by name_professor",
            ["Subject"] = "select name_subject from tableSubject order by name_subject",
            ["TimePair"] = "select description_pair from tableTimePair order by description_pair",
            ["TypeSubject"] = "select name_type_subject from tableTypeSubject order by name_type_subject"
        };
    }
}
