create proc sp_client_insert
@client_id int,
@client_name varchar(40),
@branch_id int
as
begin
insert into client(client_id,client_name,branch_id)
values(@client_id,@client_name,@branch_id)
end

create proc sp_client_view
as
begin
select * from client
end

create proc sp_client_update
@client_id int,
@client_name varchar(40),
@branch_id int
as
begin
update client
set client_id = @client_id , client_name = @client_name , branch_id = @branch_id
where client_id = @client_id
end



create proc sp_client_delete
@client_id int
as
begin
delete client
where client_id = @client_id
end

create proc sp_client_search
@client_id int
as
begin
select * from client
where client_id = @client_id
end