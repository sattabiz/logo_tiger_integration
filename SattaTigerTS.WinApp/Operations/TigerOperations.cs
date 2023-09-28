using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using UnityObjects;
using static SattaTigerTS.Entities.OrderList;


namespace SattaTigerTS.WinApp.Operations
{
    public class TigerOperations
    {
        
        public static void SendOrder()
        {
            
        }
        public static void SiparisAktar()
        {
            try

            {
                
                if (Global.uApp.Connect())

                {

                    if (Global.uApp.UserLogin("LOGO", "LOGO"))

                    {

                        if (Global.uApp.CompanyLogin(XXX, XX))

                        {


                            UnityObjects.Data purorder = Global.uApp.NewDataObject(UnityObjects.DataObjectType.doPurchOrderSlip);
                            purorder.New();
                            
                            purorder.DataFields.FieldByName("NUMBER").Value = 0014;
                            purorder.DataFields.FieldByName("DATE").Value = "05.07.2022";
                            purorder.DataFields.FieldByName("DATE").Value = 288097868;
                            purorder.DataFields.FieldByName("ARP_CODE").Value = "PF06";
                            purorder.DataFields.FieldByName("RC_RATE").Value = 16.8237;
                            //purorder.DataFields.FieldByName("RC_NET").Value = 118;
                            purorder.DataFields.FieldByName("ORDER_STATUS").Value = 4;
                            purorder.DataFields.FieldByName("CURRSEL_TOTAL").Value = 2;
                            purorder.DataFields.FieldByName("CURRSEL_DETAILS").Value = 4;


                            UnityObjects.Lines transactions_lines = purorder.DataFields.FieldByName("TRANSACTIONS").Lines;
                            transactions_lines.AppendLine();
                            transactions_lines[0].FieldByName("TYPE").Value = 0;
                            transactions_lines[0].FieldByName("MASTER_CODE").Value = "902.RLM.010";
                            transactions_lines[0].FieldByName("QUANTITY").Value = 1;
                            transactions_lines[0].FieldByName("PRICE").Value = 1696.74;
                            transactions_lines[0].FieldByName("UNIT_CODE").Value = "AD";
                            transactions_lines[0].FieldByName("UNIT_CONV1").Value = 1;
                            transactions_lines[0].FieldByName("UNIT_CONV2").Value = 1;
                            transactions_lines[0].FieldByName("DUE_DATE").Value = "06.07.2022";
                            transactions_lines[0].FieldByName("PRICE").Value = 50 * 16.8237;
                            transactions_lines[0].FieldByName("CURR_PRICE").Value = 1;
                            transactions_lines[0].FieldByName("EDT_CURR").Value = 1;
                            transactions_lines[0].FieldByName("PC_PRICE").Value = 50;
                            transactions_lines[0].FieldByName("PR_RATE").Value = 16.8237;
                            transactions_lines[0].FieldByName("EDT_PRICE").Value = 50;
                            //transactions_lines[0].FieldByName("RC_XRATE").Value = 16.9674;
                            //transactions_lines[0].FieldByName("CURR_TRANSACTIN").Value = 1;
                            transactions_lines[0].FieldByName("AFFECT_COLLATRL").Value = 1;
                            transactions_lines[0].FieldByName("MULTI_ADD_TAX").Value = 0;
                            transactions_lines[0].FieldByName("AFFECT_RISK").Value = 1;
                            transactions_lines[0].FieldByName("EXCLINE_PRICE").Value = 100;
                            //transactions_lines[0].FieldByName("EXCLINE_TOTAL").Value = 100;
                            //transactions_lines[0].FieldByName("EXCLINE_VAT_AMOUNT").Value = 18;
                            //transactions_lines[0].FieldByName("EXCLINE_VAT_MATRAH").Value = 100;
                            //transactions_lines[0].FieldByName("EXCLINE_LINE_NET").Value = 100;
                            //transactions_lines[0].FieldByName("EDT_PRICE").Value = 100;
                            //transactions_lines[0].FieldByName("EDT_CURR").Value = 1;
                            //transactions_lines[0].FieldByName("ORG_DUE_DATE").Value = "06.07.2022";
                            //transactions_lines[0].FieldByName("ORG_QUANTITY").Value = 1;
                            //transactions_lines[0].FieldByName("ORG_PRICE").Value = 1696.74;
                            
                            //purorder.DataFields.FieldByName("CURR_TRANSACTIN").Value = 1;
                            //purorder.DataFields.FieldByName("TC_RATE").Value = 16.9674;
                            purorder.DataFields.FieldByName("AFFECT_COLLATRL").Value = 1;
                            purorder.DataFields.FieldByName("AFFECT_RISK").Value = 1;
                            purorder.DataFields.FieldByName("EXCHINFO_TOTAL_DISCOUNTED").Value = 100;
                            purorder.DataFields.FieldByName("DEDUCTIONPART1").Value = 2;
                            purorder.DataFields.FieldByName("DEDUCTIONPART2").Value = 3;
                            //purorder.DataFields.FieldByName("EINVOICE_TURETPRICESTR").Value = S�f�r TL;
                            if (purorder.Post() == true)
                            {
                                string HataTarih = DateTime.Now.ToString("yyyyMMddHHmmss").ToString();
                                purorder.ExportToXML("", @"C:\XMLTIGER\" + HataTarih + ".xml");
                                MessageBox.Show("POST OK !");
                            }
                            else
                            {
                                if (purorder.ErrorCode != 0)
                                {
                                    MessageBox.Show("DBError(" + purorder.ErrorCode.ToString() + ")-" + purorder.ErrorDesc + purorder.DBErrorDesc);
                                }
                                else if (purorder.ValidateErrors.Count > 0)
                                {
                                    string result = "XML ErrorList:";
                                    for (int i = 0; i < purorder.ValidateErrors.Count; i++)
                                    {
                                        result += "(" + purorder.ValidateErrors[i].ID.ToString() + ") - " + purorder.ValidateErrors[i].Error;
                                    }
                                    MessageBox.Show(result);
                                }
                            }
                        }
                    }
                }

            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.Message);
            } //catch
        }

    }

}
