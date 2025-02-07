/* Write your T-SQL query statement below */
select c.name 
FROM Customer AS c
where c.referee_id <> 2 or c.referee_id is null
