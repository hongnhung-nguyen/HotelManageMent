CONNECT HOTEL_PUBLIC/password@localhost:1521/HOTEL;
SET SERVEROUTPUT ON;

/*
    Check connection availability
*/

DECLARE
  v_service_name VARCHAR2(100);
BEGIN
  SELECT SYS_CONTEXT('USERENV', 'SERVICE_NAME') INTO v_service_name FROM DUAL;
  DBMS_OUTPUT.PUT_LINE('Service Name: ' || v_service_name);
END;
/

/*
    các hàm thủ tục
*/

CREATE OR REPLACE PROCEDURE A_insertEmployee(
    MANVnew   in      VARCHAR2,
    TENNV   in     VARCHAR2,
    PHAI     in    VARCHAR2,
    NGAYSINH  in   DATE,
    SODT      in   VARCHAR2,
    CCCD     in    VARCHAR2 ,  
    EMAIL    in    VARCHAR2,
    VAITRO    in   NVARCHAR2, 
    DIACHI    in   VARCHAR2,
    MATKHAU    in  VARCHAR2
)
AS
str VARCHAR2(3000);
BEGIN
    INSERT INTO HOTEL_PUBLIC.A_NHANVIEN VALUES(MANVnew, TENNV, PHAI, NGAYSINH,SODT ,CCCD,EMAIL, VAITRO ,DIACHI );
--    str := 'ALTER SESSION SET "_ORACLE_SCRIPT"=TRUE';
--    EXECUTE IMMEDIATE  (str);
--    str := 'CREATE USER '||MANVnew||' IDENTIFIED BY '||MATKHAU;
--     EXECUTE IMMEDIATE  (str);
--    str:= 'GRANT HOTEL_EMP TO '|| MANVnew;
--     EXECUTE IMMEDIATE  (str);
END;
/

