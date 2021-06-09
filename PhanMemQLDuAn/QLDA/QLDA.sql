if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CUNGCAP') and o.name = 'FK_CUNGCAP_CUNGCAP_NHACCAP')
alter table CUNGCAP
   drop constraint FK_CUNGCAP_CUNGCAP_NHACCAP
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CUNGCAP') and o.name = 'FK_CUNGCAP_CUNGCAP2_DUAN')
alter table CUNGCAP
   drop constraint FK_CUNGCAP_CUNGCAP2_DUAN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CUNGUNG') and o.name = 'FK_CUNGUNG_DUOC_DUAN')
alter table CUNGUNG
   drop constraint FK_CUNGUNG_DUOC_DUAN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CUNGUNG') and o.name = 'FK_CUNGUNG_HANGHOA_HANGHOA')
alter table CUNGUNG
   drop constraint FK_CUNGUNG_HANGHOA_HANGHOA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DAUTU') and o.name = 'FK_DAUTU_DAUTU_NHADAUTU')
alter table DAUTU
   drop constraint FK_DAUTU_DAUTU_NHADAUTU
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DAUTU') and o.name = 'FK_DAUTU_DAUTU2_DUAN')
alter table DAUTU
   drop constraint FK_DAUTU_DAUTU2_DUAN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DUAN') and o.name = 'FK_DUAN_THI_CONG_CTYTHICO')
alter table DUAN
   drop constraint FK_DUAN_THI_CONG_CTYTHICO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('HANGHOA') and o.name = 'FK_HANGHOA_CO_NHACCAP')
alter table HANGHOA
   drop constraint FK_HANGHOA_CO_NHACCAP
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('NHANVIEN') and o.name = 'FK_NHANVIEN_THAM_GIA_DUAN')
alter table NHANVIEN
   drop constraint FK_NHANVIEN_THAM_GIA_DUAN
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CTYTHICONG')
            and   type = 'U')
   drop table CTYTHICONG
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CUNGCAP')
            and   name  = 'CUNGCAP2_FK'
            and   indid > 0
            and   indid < 255)
   drop index CUNGCAP.CUNGCAP2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CUNGCAP')
            and   name  = 'CUNGCAP_FK'
            and   indid > 0
            and   indid < 255)
   drop index CUNGCAP.CUNGCAP_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CUNGCAP')
            and   type = 'U')
   drop table CUNGCAP
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CUNGUNG')
            and   name  = 'DUOC_FK'
            and   indid > 0
            and   indid < 255)
   drop index CUNGUNG.DUOC_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CUNGUNG')
            and   name  = 'HANGHOA_FK'
            and   indid > 0
            and   indid < 255)
   drop index CUNGUNG.HANGHOA_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CUNGUNG')
            and   type = 'U')
   drop table CUNGUNG
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('DAUTU')
            and   name  = 'DAUTU2_FK'
            and   indid > 0
            and   indid < 255)
   drop index DAUTU.DAUTU2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('DAUTU')
            and   name  = 'DAUTU_FK'
            and   indid > 0
            and   indid < 255)
   drop index DAUTU.DAUTU_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DAUTU')
            and   type = 'U')
   drop table DAUTU
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('DUAN')
            and   name  = 'THI_CONG_FK'
            and   indid > 0
            and   indid < 255)
   drop index DUAN.THI_CONG_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DUAN')
            and   type = 'U')
   drop table DUAN
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('HANGHOA')
            and   name  = 'CO_FK'
            and   indid > 0
            and   indid < 255)
   drop index HANGHOA.CO_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('HANGHOA')
            and   type = 'U')
   drop table HANGHOA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('NHACCAP')
            and   type = 'U')
   drop table NHACCAP
go

if exists (select 1
            from  sysobjects
           where  id = object_id('NHADAUTU')
            and   type = 'U')
   drop table NHADAUTU
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('NHANVIEN')
            and   name  = 'THAM_GIA_FK'
            and   indid > 0
            and   indid < 255)
   drop index NHANVIEN.THAM_GIA_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('NHANVIEN')
            and   type = 'U')
   drop table NHANVIEN
go

/*==============================================================*/
/* Table: CTYTHICONG                                            */
/*==============================================================*/
create table CTYTHICONG (
   MACTTC               varchar(10)          not null,
   TENCTTC              varchar(50)          null,
   constraint PK_CTYTHICONG primary key nonclustered (MACTTC)
)
go

/*==============================================================*/
/* Table: CUNGCAP                                               */
/*==============================================================*/
create table CUNGCAP (
   MANCC                varchar(10)          not null,
   MADUAN               varchar(10)          not null,
   constraint PK_CUNGCAP primary key (MANCC, MADUAN)
)
go

/*==============================================================*/
/* Index: CUNGCAP_FK                                            */
/*==============================================================*/
create index CUNGCAP_FK on CUNGCAP (
MANCC ASC
)
go

/*==============================================================*/
/* Index: CUNGCAP2_FK                                           */
/*==============================================================*/
create index CUNGCAP2_FK on CUNGCAP (
MADUAN ASC
)
go

/*==============================================================*/
/* Table: CUNGUNG                                               */
/*==============================================================*/
create table CUNGUNG (
   STT                  int                  not null,
   MAHANG               varchar(10)          not null,
   MADUAN               varchar(10)          not null,
   SOLUONG              int                  null,
   constraint PK_CUNGUNG primary key nonclustered (STT)
)
go

/*==============================================================*/
/* Index: HANGHOA_FK                                            */
/*==============================================================*/
create index HANGHOA_FK on CUNGUNG (
MAHANG ASC
)
go

/*==============================================================*/
/* Index: DUOC_FK                                               */
/*==============================================================*/
create index DUOC_FK on CUNGUNG (
MADUAN ASC
)
go

/*==============================================================*/
/* Table: DAUTU                                                 */
/*==============================================================*/
create table DAUTU (
   MANDT                varchar(10)          not null,
   MADUAN               varchar(10)          not null,
   constraint PK_DAUTU primary key (MANDT, MADUAN)
)
go

/*==============================================================*/
/* Index: DAUTU_FK                                              */
/*==============================================================*/
create index DAUTU_FK on DAUTU (
MANDT ASC
)
go

/*==============================================================*/
/* Index: DAUTU2_FK                                             */
/*==============================================================*/
create index DAUTU2_FK on DAUTU (
MADUAN ASC
)
go

/*==============================================================*/
/* Table: DUAN                                                  */
/*==============================================================*/
create table DUAN (
   MADUAN               varchar(10)          not null,
   MACTTC               varchar(10)          not null,
   TENDUAN              varchar(50)          null,
   THANHPHO_DUAN        varchar(50)          null,
   TGBD                 datetime             null,
   DUKIENHT             datetime             null,
   TGHT                 datetime             null,
   constraint PK_DUAN primary key nonclustered (MADUAN)
)
go

/*==============================================================*/
/* Index: THI_CONG_FK                                           */
/*==============================================================*/
create index THI_CONG_FK on DUAN (
MACTTC ASC
)
go

/*==============================================================*/
/* Table: HANGHOA                                               */
/*==============================================================*/
create table HANGHOA (
   MAHANG               varchar(10)          not null,
   MANCC                varchar(10)          not null,
   TENHANG              varchar(50)          null,
   MAU                  varchar(10)          null,
   TRONGLUONG           int                  null,
   constraint PK_HANGHOA primary key nonclustered (MAHANG)
)
go

/*==============================================================*/
/* Index: CO_FK                                                 */
/*==============================================================*/
create index CO_FK on HANGHOA (
MANCC ASC
)
go

/*==============================================================*/
/* Table: NHACCAP                                               */
/*==============================================================*/
create table NHACCAP (
   MANCC                varchar(10)          not null,
   TENNCC               varchar(50)          null,
   VON                  int                  null,
   THPHO                varchar(50)          null,
   SDTNCC               char(11)             null,
   constraint PK_NHACCAP primary key nonclustered (MANCC)
)
go

/*==============================================================*/
/* Table: NHADAUTU                                              */
/*==============================================================*/
create table NHADAUTU (
   MANDT                varchar(10)          not null,
   TENNDT               varchar(50)          null,
   SOTIEN               numeric(12)          null,
   constraint PK_NHADAUTU primary key nonclustered (MANDT)
)
go

/*==============================================================*/
/* Table: NHANVIEN                                              */
/*==============================================================*/
create table NHANVIEN (
   MANV                 varchar(10)          not null,
   MADUAN               varchar(10)          not null,
   TENNV                varchar(50)          null,
   NAMSINH              datetime             null,
   SDTNV                char(11)             null,
   DIACHINV             varchar(50)          null,
   constraint PK_NHANVIEN primary key nonclustered (MANV)
)
go

/*==============================================================*/
/* Index: THAM_GIA_FK                                           */
/*==============================================================*/
create index THAM_GIA_FK on NHANVIEN (
MADUAN ASC
)
go

alter table CUNGCAP
   add constraint FK_CUNGCAP_CUNGCAP_NHACCAP foreign key (MANCC)
      references NHACCAP (MANCC)
go

alter table CUNGCAP
   add constraint FK_CUNGCAP_CUNGCAP2_DUAN foreign key (MADUAN)
      references DUAN (MADUAN)
go

alter table CUNGUNG
   add constraint FK_CUNGUNG_DUOC_DUAN foreign key (MADUAN)
      references DUAN (MADUAN)
go

alter table CUNGUNG
   add constraint FK_CUNGUNG_HANGHOA_HANGHOA foreign key (MAHANG)
      references HANGHOA (MAHANG)
go

alter table DAUTU
   add constraint FK_DAUTU_DAUTU_NHADAUTU foreign key (MANDT)
      references NHADAUTU (MANDT)
go

alter table DAUTU
   add constraint FK_DAUTU_DAUTU2_DUAN foreign key (MADUAN)
      references DUAN (MADUAN)
go

alter table DUAN
   add constraint FK_DUAN_THI_CONG_CTYTHICO foreign key (MACTTC)
      references CTYTHICONG (MACTTC)
go

alter table HANGHOA
   add constraint FK_HANGHOA_CO_NHACCAP foreign key (MANCC)
      references NHACCAP (MANCC)
go

alter table NHANVIEN
   add constraint FK_NHANVIEN_THAM_GIA_DUAN foreign key (MADUAN)
      references DUAN (MADUAN)
go
alter table NHANVIEN
alter column DIACHINV nvarchar(50)
select da.MADUAN,da.TENDUAN,da.THANHPHO_DUAN,ct.TENCTTC,dt.TENNDT,nv.TENNV,da.TGBD,da.DUKIENHT,da.TGHT
from DUAN da,NHANVIEN nv,DAUTU d,NHADAUTU dt,CTYTHICONG ct
where da.MADUAN = nv.MADUAN and
d.MADUAN = da.MADUAN and
ct.MACTTC = da.MACTTC and
dt.MANDT = d.MANDT

select da.MADUAN,da.TENDUAN,da.THANHPHO_DUAN,ct.TENCTTC,da.TGBD,da.DUKIENHT,da.TGHT,nv.TENNV,ndt.TENNDT
from DUAN da,CTYTHICONG ct,NHANVIEN nv,NHADAUTU ndt,DAUTU dt
where da.MACTTC = ct.MACTTC
and nv.MADUAN = da.MADUAN
and dt.MADUAN = da.MADUAN
and ndt.MANDT = dt.

