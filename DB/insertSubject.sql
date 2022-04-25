insert into timeTable
select g.index_group,
w.index_week,
d.index_day,
t.index_pair,
s.index_subject,
ts.index_type_subject,
p.index_professor
from tableGroup as g, 
tableWeek as w, 
tableDayWeek as d, 
tableTimePair as t,  
tableSubject as s,
tableTypeSubject as ts,
tableProfessor as p
where g.abbrev_group like 'СП041' and
w.neme_arabic_week in (4) and
d.name_day like 'Понедельник' and
t.index_pair in (4, 5) and
s.abbrev_subject like 'ОТТ' and
ts.abbrev_type_sybject like 'ЛР' and
p.short_name_professor like 'Киркоров С. И.'