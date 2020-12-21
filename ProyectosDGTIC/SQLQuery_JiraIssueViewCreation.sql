use GestionProyectoTI;
go

create view dbo.JiraIssueView as
select i.ID as 'IssueID', i.issuetype as 'TypeID', t.pname as 'IssueType',s.ID as 'StatusID', s.pname as 'Status', u.ID as 'AssigneeID', i.ASSIGNEE as 'Username', u.display_name as 'Assignee', g.ID as 'GroupID', g.group_name as 'Group', i.SUMMARY as 'Summary', 
	p.ID as 'ProjectID', p.pname as 'Project', p.pcounter as 'ProjectTotal', i.CREATED as 'Created', i.TIMEESTIMATE as 'TimeEstimate', i.TIMEORIGINALESTIMATE as 'TimeOriginalEstimate', i.RESOLUTION as 'Resolution', i.RESOLUTIONDATE as 'ResolutionDate', p.PROJECTTYPE as 'ProjectType'  
	from JiraDesarrolllo.dbo.jiraissue as i
left join JiraDesarrolllo.dbo.issuetype as t
on t.ID = i.issuetype
left join JiraDesarrolllo.dbo.app_user as a 
on a.user_key = i.ASSIGNEE
left join JiraDesarrolllo.dbo.cwd_membership as m
on a.lower_user_name = m.lower_child_name
left join JiraDesarrolllo.dbo.cwd_user as u
on u.ID = m.child_id
left join JiraDesarrolllo.dbo.project as p
on p.ID = i.PROJECT
left join JiraDesarrolllo.dbo.issuestatus as s
on s.ID = i.issuestatus
left join JiraDesarrolllo.dbo.cwd_group as g
on m.parent_id = g.ID;
go