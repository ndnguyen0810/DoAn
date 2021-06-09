use QuanLyBaoChi_New
go

--SELECT
select * from theloai
go

select * from PHATHANH
go

select * from QUYEN
go

select * from BAOTAPCHI
go

select * from NHABAO
go

select * from BAIVIET
go

select * from BAIBAO
go

select * from BAIDANG
go


--PROC LOAD TABLE

exec USP_LoadTheLoai
go

exec USP_LoadPhatHanh
go

exec USP_LoadTapChi
go

exec USP_LoadNhaBao
go
