CONNECT HOTEL_PUBLIC/password@localhost:1521/HOTEL;
SET SERVEROUTPUT ON;

/*
    Check connection availability
*/
SET SERVEROUTPUT ON

DECLARE
  v_service_name VARCHAR2(100);
BEGIN
  SELECT SYS_CONTEXT('USERENV', 'SERVICE_NAME') INTO v_service_name FROM DUAL;
  DBMS_OUTPUT.PUT_LINE('Service Name: ' || v_service_name);
END;
/
/*
    Insert records
*/
-- khách hàng
INSERT INTO A_KHACHHANG VALUES ('KH001','Nguyễn A','Nữ',TO_DATE('2003/07/09', 'yyyy/mm/dd'),'0123293', '214325435','abc@gmail.com', 'TP HCM');
INSERT INTO A_KHACHHANG VALUES ('KH002','Nguyễn B','Nữ',TO_DATE('2003/07/09', 'yyyy/mm/dd'),'0123293', '31232143','xyz@gmail.com' ,'TP HCM');
INSERT INTO A_KHACHHANG VALUES ('KH003','Nguyễn C','Nữ',TO_DATE('2003/07/09', 'yyyy/mm/dd'),'0123293', '2343254554','12325@gmail.com', 'TP HCM');
INSERT INTO A_KHACHHANG VALUES ('KH004','Nguyễn D','Nam',TO_DATE('2003/07/09', 'yyyy/mm/dd'),'0123293', '23545436','bca@gmail.com', 'TP HCM');
INSERT INTO A_KHACHHANG VALUES ('KH005','Nguyễn E','Nam',TO_DATE('2003/07/09', 'yyyy/mm/dd'),'0123293', '3463564564','12321@gmail.com', 'TP HCM');
-- nhân viên
INSERT INTO A_KHACHHANG VALUES ('NV001','Nguyễn A','Nữ',TO_DATE('2003/07/09', 'yyyy/mm/dd'),'0123293', '214325435','abc@gmail.com','Nhân viên', 'TP HCM');
INSERT INTO A_KHACHHANG VALUES ('NV002','Nguyễn B','Nữ',TO_DATE('2003/07/09', 'yyyy/mm/dd'),'0123293', '31232143','xyz@gmail.com' ,'Nhân viên','TP HCM');
INSERT INTO A_KHACHHANG VALUES ('NV003','Nguyễn C','Nữ',TO_DATE('2003/07/09', 'yyyy/mm/dd'),'0123293', '2343254554','12325@gmail.com','Nhân viên', 'TP HCM');
INSERT INTO A_KHACHHANG VALUES ('NV004','Nguyễn D','Nam',TO_DATE('2003/07/09', 'yyyy/mm/dd'),'0123293', '23545436','bca@gmail.com','Nhân viên', 'TP HCM');
INSERT INTO A_KHACHHANG VALUES ('NV005','Nguyễn E','Nam',TO_DATE('2003/07/09', 'yyyy/mm/dd'),'0123293', '3463564564','12321@gmail.com','Nhân viên', 'TP HCM');
--phong
INSERT INTO A_PHONG VALUES(
