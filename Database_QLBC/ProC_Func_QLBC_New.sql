use QuanLyBaoChi_New
go

/*==================================================*/
/*					FUNCTION						*/
/*==================================================*/


CREATE FUNCTION AUTO_ID_TL()
RETURNS int
AS
BEGIN
	DECLARE @ID int
	IF (SELECT COUNT(ID_TheLoai) FROM THeLoai) = 0
		SET @ID = 0
	ELSE
		SELECT @ID = MAX(ID_TheLoai) FROM TheLoai
		SELECT @ID = CASE
			WHEN @ID >= 0 then @ID+1
		END
	RETURN @ID
END
go

--phat hanh--

CREATE FUNCTION AUTO_ID_PH()
RETURNS int
AS
BEGIN
	DECLARE @ID int
	IF (SELECT COUNT(ID_PhatHanh) FROM PhatHanh) = 0
		SET @ID = 0
	ELSE
		SELECT @ID = MAX(ID_PhatHanh) FROM PhatHanh
		SELECT @ID = CASE
			WHEN @ID >= 0 then @ID+1
		END
	RETURN @ID
END
go

--Quyen--

CREATE FUNCTION AUTO_ID_Quyen()
RETURNS int
AS
BEGIN
	DECLARE @ID int
	IF (SELECT COUNT(ID_Quyen) FROM Quyen) = 0
		SET @ID = 0
	ELSE
		SELECT @ID = MAX(ID_Quyen) FROM Quyen
		SELECT @ID = CASE
			WHEN @ID >= 0 then @ID+1
		END
	RETURN @ID
END
go

--bao tap chi--
CREATE FUNCTION AUTO_ID_TapChi()
RETURNS int
AS
BEGIN
	DECLARE @ID int
	IF (SELECT COUNT(ID_TapChi) FROM BaoTapChi) = 0
		SET @ID = 0
	ELSE
		SELECT @ID = MAX(ID_TapChi) FROM BaoTapChi
		SELECT @ID = CASE
			WHEN @ID >= 0 then @ID+1
		END
	RETURN @ID
END
go

--Nha Bao--
CREATE FUNCTION AUTO_ID_NhaBao()
RETURNS int
AS
BEGIN
	DECLARE @ID int
	IF (SELECT COUNT(ID_NhaBao) FROM NhaBao) = 0
		SET @ID = 0
	ELSE
		SELECT @ID = MAX(ID_NhaBao) FROM NhaBao
		SELECT @ID = CASE
			WHEN @ID >= 0 then @ID+1
		END
	RETURN @ID
END
go

-- Bai Viet
CREATE FUNCTION AUTO_ID_BaiViet()
RETURNS int
AS
BEGIN
	DECLARE @ID int
	IF (SELECT COUNT(ID_BaiViet) FROM BaiViet) = 0
		SET @ID = 0
	ELSE
		SELECT @ID = MAX(ID_BaiViet) FROM BaiViet
		SELECT @ID = CASE
			WHEN @ID >= 0 then @ID+1
		END
	RETURN @ID
END
go


-- Bai Bao
CREATE FUNCTION AUTO_ID_BaiBao()
RETURNS int
AS
BEGIN
	DECLARE @ID int
	IF (SELECT COUNT(ID_BaiBao) FROM BaiBao) = 0
		SET @ID = 0
	ELSE
		SELECT @ID = MAX(ID_BaiBao) FROM BaiBao
		SELECT @ID = CASE
			WHEN @ID >= 0 then @ID+1
		END
	RETURN @ID
END
go


/*==================================================*/
/*					PROC							*/
/*==================================================*/


