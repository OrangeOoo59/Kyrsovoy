select g.abbrev_group, 
w.name_rome_week, 
d.name_day, 
t.index_pair, 
s.abbrev_subject, 
ts.abbrev_type_sybject, 
p.short_name_professor
from 
timeTable as tt join 
tableGroup as g on tt.index_group = g.index_group join 
tableWeek as w on tt.index_week = w.index_week join
tableDayWeek as d on tt.index_day_week = d.index_day join
tableTimePair as t on tt.index_time_pair = t.index_pair join
tableSubject as s on tt.index_subject = s.index_subject join
tableTypeSubject as ts on tt.index_type_subject = ts.index_type_subject join
tableProfessor as p on tt.index_professor = p.index_professor
where g.abbrev_group = 'ÑÏ041'