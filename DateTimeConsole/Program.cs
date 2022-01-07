DateTime dt = DateTime.Now; 

DateOnly d = DateOnly.FromDateTime(dt);

TimeOnly t = TimeOnly.FromDateTime(dt);

DateTime dt2 = d.ToDateTime(new TimeOnly(10,30));

var ts = t.ToTimeSpan();