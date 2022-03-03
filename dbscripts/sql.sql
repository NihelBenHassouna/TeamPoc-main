
\connect postgres


CREATE TABLE TRANS_MW_AGG_SLOT_HOURLY
(
          
   network_sid SERIAL PRIMARY KEY,
RSL_DEVIATION VARCHAR (50) NOT NULL,
checkpoint VARCHAR (50) NOT NULL
 
);

CREATE TABLE TRANS_MW_ERC_PM_WAN_RFINPUTPOWER
(
   network_sid SERIAL PRIMARY KEY,
NeId VARCHAR (50) NOT NULL,
NodeName  VARCHAR (50)  NOT NULL,
   Object  VARCHAR (50)  NOT NULL,
Time  VARCHAR (50)  NOT NULL,
Interval  VARCHAR (50)  NOT NULL,
Direction  VARCHAR (50)  NOT NULL,
NeAlias  VARCHAR (50)  NOT NULL,
NeType  VARCHAR (50)  NOT NULL,
Position  VARCHAR (50)  NOT NULL,
RxLevelBelowTS1  VARCHAR (50)  NOT NULL,
RxLevelBelowTS2  VARCHAR (50)  NOT NULL,
MinRxLevel  VARCHAR (50)  NOT NULL,
MaxRxLevel  VARCHAR (50)  NOT NULL,
TxLevelAboveTS1  VARCHAR (50)  NOT NULL,
MinTxLevel  VARCHAR (50)  NOT NULL,
MaxTxLevel  VARCHAR (50)  NOT NULL,
IdLogNum  VARCHAR (50)  NOT NULL,
FailureDescription  VARCHAR (50)  NOT NULL
);

CREATE TABLE TRANS_MW_ERC_PM_TN_RADIO_LINK_POWER
(
network_sid SERIAL PRIMARY KEY,
NeId VARCHAR (50) NOT NULL,
NodeName  VARCHAR (50)  NOT NULL,
Object  VARCHAR (50)  NOT NULL,
Time  VARCHAR (50)  NOT NULL,
Interval  VARCHAR (50)  NOT NULL,
Direction  VARCHAR (50)  NOT NULL,
NeAlias  VARCHAR (50)  NOT NULL,
NeType  VARCHAR (50)  NOT NULL,
Position  VARCHAR (50)  NOT NULL,
RFInputPower  VARCHAR (50)  NOT NULL,
MeanRxLevel1m  VARCHAR (50)  NOT NULL,
IdLogNum  VARCHAR (50)  NOT NULL,
TID  VARCHAR (50)  NOT NULL,
FarEndTID  VARCHAR (50)  NOT NULL,
FailureDescription  VARCHAR (50)  NOT NULL);


ALTER TABLE TRANS_MW_ERC_PM_WAN_RFINPUTPOWER OWNER TO postgres;
ALTER TABLE TRANS_MW_ERC_PM_TN_RADIO_LINK_POWER OWNER TO postgres;
ALTER TABLE TRANS_MW_AGG_SLOT_HOURLY OWNER TO postgres;


Insert into TRANS_MW_ERC_PM_WAN_RFINPUTPOWER(NeId,NodeName,Object,Time,Interval,Direction,NeAlias,NeType,Position,RxLevelBelowTS1,RxLevelBelowTS2,MinRxLevel,MaxRxLevel,TxLevelAboveTS1,MinTxLevel,MaxTxLevel,IdLogNum,FailureDescription
) values( '1','NodeName','Object','Time','Interval','Direction','NeAlias','NeType','Position','RxLevelBelowTS1','RxLevelBelowTS2','MinRxLevel','MaxRxLevel','TxLevelAboveTS1','MinTxLevel','MaxTxLevel','IdLogNum','FailureDescription');
 
 Insert into TRANS_MW_ERC_PM_WAN_RFINPUTPOWER(NeId,NodeName,Object,Time,Interval,Direction,NeAlias,NeType,Position,RxLevelBelowTS1,RxLevelBelowTS2,MinRxLevel,MaxRxLevel,TxLevelAboveTS1,MinTxLevel,MaxTxLevel,IdLogNum,FailureDescription
) values( '2','NodeName','Object','Time','Interval','Direction','NeAlias','NeType','Position','RxLevelBelowTS1','RxLevelBelowTS2','MinRxLevel','MaxRxLevel','TxLevelAboveTS1','MinTxLevel','MaxTxLevel','IdLogNum','FailureDescription');
 
Insert into TRANS_MW_ERC_PM_TN_RADIO_LINK_POWER (NeId, NodeName, Object, Time, Interval, Direction, NeAlias, NeType, Position, RFInputPower, MeanRxLevel1m, IdLogNum ,TID, FarEndTID,FailureDescription) values( '1', 'NodeName', 'Object', 'Time', 'Interval', 'Direction', 'NeAlias', 'NeType', 'Position', 'RFInputPower', 'MeanRxLevel1m', 'IdLogNum', 'TID', 'FarEndTID','FailureDescription');
Insert into TRANS_MW_ERC_PM_TN_RADIO_LINK_POWER (NeId, NodeName, Object, Time, Interval, Direction, NeAlias, NeType, Position, RFInputPower, MeanRxLevel1m, IdLogNum ,TID, FarEndTID,FailureDescription) values( '1', 'NodeName', 'Object', 'Time', 'Interval', 'Direction', 'NeAlias', 'NeType', 'Position', 'RFInputPower', 'MeanRxLevel1m', 'IdLogNum', 'TID', 'FarEndTID','FailureDescription');

 

Insert into TRANS_MW_AGG_SLOT_HOURLY(RSL_DEVIATION,checkpoint) values( '1','2005-01-01');
Insert into TRANS_MW_AGG_SLOT_HOURLY(RSL_DEVIATION,checkpoint) values( '1','2005-01-01');
Insert into TRANS_MW_AGG_SLOT_HOURLY(RSL_DEVIATION,checkpoint) values( '2','2005-01-01');
Insert into TRANS_MW_AGG_SLOT_HOURLY(RSL_DEVIATION,checkpoint) values( '2','2005-01-01');
Insert into TRANS_MW_AGG_SLOT_HOURLY(RSL_DEVIATION,checkpoint) values( '3','2005-01-01');
Insert into TRANS_MW_AGG_SLOT_HOURLY(RSL_DEVIATION,checkpoint) values( '3','2005-01-01');

