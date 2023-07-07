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
    Phân các quyền

*/

CREATE ROLE HOTEL_EMP;
/
BEGIN
    EXECUTE IMMEDIATE 'GRANT CREATE SESSION TO HOTEL_EMP';
    EXECUTE IMMEDIATE 'GRANT CONNECT TO HOTEL_EMP';
    EXECUTE IMMEDIATE 'GRANT SELECT ON A_KHACHHANG TO HOTEL_EMP';
    DBMS_OUTPUT.PUT_LINE('The grant priv is created successfully!!');
EXCEPTION
    WHEN OTHERS THEN
        DBMS_OUTPUT.PUT_LINE('The Public Schema is already exists, so do not create a new one!!');
END;
/