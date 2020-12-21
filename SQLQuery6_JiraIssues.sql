use JiraDesarrolllo;
go

--select u.display_name, u.lower_user_name, m.child_name, i.ASSIGNEE, u.ID, m.child_id, i.ID, m.parent_name from dbo.cwd_user as u 
--left join dbo.cwd_membership as m 
--on m.child_id = u.ID
--left join dbo.jiraissue as i 
--on u.user_name like i.ASSIGNEE;
--go

select i.ID as 'IssueID', i.issuetype as 'TypeID', t.pname as 'IssueType',s.ID as 'StatusID', s.pname as 'Status', u.ID as 'AssigneeID', i.ASSIGNEE as 'Username', u.display_name as 'Assignee', g.ID as 'GroupID', g.group_name as 'Group', i.SUMMARY as 'Summary', 
	p.ID as 'ProyectID', p.pname as 'Project', p.pcounter as 'ProyectoTotal', i.CREATED as 'Created', i.TIMEESTIMATE as 'TimeEstimate', i.TIMEORIGINALESTIMATE, i.RESOLUTION, i.RESOLUTIONDATE, p.PROJECTTYPE as 'ProyectoType'  
	from dbo.jiraissue as i
left join dbo.issuetype as t
on t.ID = i.issuetype
left join dbo.app_user as a 
on a.user_key = i.ASSIGNEE
left join dbo.cwd_membership as m
on a.lower_user_name = m.lower_child_name
left join dbo.cwd_user as u
on u.ID = m.child_id
left join dbo.project as p
on p.ID = i.PROJECT
left join dbo.issuestatus as s
on s.ID = i.issuestatus
left join dbo.cwd_group as g
on m.parent_id = g.ID;
go

--create view dbo.sigetic as
--select i.ID as 'IssueID', s.ID as 'StatusID', s.pname as 'Status', u.ID as 'UserID', i.ASSIGNEE, u.display_name as 'Responsable', g.ID as 'GrupoID', g.group_name as 'Grupo', i.SUMMARY as 'Descripcion', 
--	p.ID as 'ProyectoID', p.pname as 'Projecto', p.pcounter as 'ProyectoTareas', i.CREATED, i.TIMEESTIMATE, i.TIMEORIGINALESTIMATE, i.RESOLUTION, i.RESOLUTIONDATE, p.PROJECTTYPE as 'ProyectoTipo'  
--	from dbo.jiraissue as i
--left join dbo.app_user as a 
--on a.user_key = i.ASSIGNEE
--left join dbo.cwd_membership as m
--on a.lower_user_name = m.lower_child_name
--left join dbo.cwd_user as u
--on u.ID = m.child_id
--left join dbo.project as p
--on p.ID = i.PROJECT
--left join dbo.issuestatus as s
--on s.ID = i.issuestatus
--left join dbo.cwd_group as g
--on m.parent_id = g.ID;
--go