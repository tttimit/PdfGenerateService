﻿Create Table FormDataItems(
user_id char(20) Not Null Primary key,
name_fam nvarchar(100) Not Null,
name_giv nvarchar(100) Not Null,
dob date Not Null,
birth_town nvarchar(100) Not Null,
birth_cntry nvarchar(100) Not Null,
relations char(13) Not Null,
pass_no nvarchar(100) Not Null,
pass_cntry  nvarchar(100) Not Null,
ident_no nvarchar(100) Not Null,
ident_cntry nvarchar(100) Not Null,
cit nvarchar(100) Not Null,
resi_tr nvarchar(100) Not Null,
resi_sub nvarchar(100) Not Null,
resi_cntry nvarchar(100) Not Null,
resi_pc nvarchar(100) Not Null,
corresp_str nvarchar(100) Not Null,
corresp_sub nvarchar(100) ,
corresp_cntry nvarchar(100) ,
corresp_hap nvarchar(100) ,
off_ph_cc nvarchar(10),
off_ph_ac nvarchar(10),
off_ph nvarchar(20),
after_ph_cc nvarchar(10),
after_ph_ac nvarchar(10),
off_pn nvarchar(20),
com_dimia char Not Null,
fax_cc nvarchar(10) Not Null,
fax_ac nvarchar(10) Not Null,
fax_ph nvarchar(20) Not Null,
email nvarchar(100) Not Null,
file_np nvarchar(100),
)