using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebserviceGS
{
    /// <summary>
    /// WebService1 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string ERP_TO_MES_DataTransport(string Factory, string task_name, string descript, string create_time, string creator, string operatype,
                                               string source_table, string target_table, string data, string data_inserted, string data_deleted)
        {
            string res = "";
            try
            {
                //List<SqlParameter> list = new List<SqlParameter>();
                //list.Add(new SqlParameter("@task_name", task_name));
                //list.Add(new SqlParameter("@descript", descript));
                //list.Add(new SqlParameter("@create_time", create_time));
                //list.Add(new SqlParameter("@creator", creator));
                //list.Add(new SqlParameter("@operatype", operatype));
                //list.Add(new SqlParameter("@source_table", source_table));
                //list.Add(new SqlParameter("@target_table", target_table));
                //list.Add(new SqlParameter("@data", data));
                //list.Add(new SqlParameter("@data_inserted", data_inserted));
                //list.Add(new SqlParameter("@data_deleted", data_deleted));


                //     IDataParameter[] parametert = new IDataParameter[]
                //{
                //      new OracleParameter("task_name", OracleType.NVarChar,500),
                //      new OracleParameter("descript",OracleType.NVarChar,500),
                //      new OracleParameter("create_time",OracleType.NVarChar,500),
                //      new OracleParameter("creator",OracleType.NVarChar,500),
                //      new OracleParameter("operatype",OracleType.NVarChar,500),
                //      new OracleParameter("source_table",OracleType.NVarChar,500),
                //      new OracleParameter("target_table",OracleType.NVarChar,500),
                //      new OracleParameter("data",OracleType.DateTime),
                //      new OracleParameter("data_inserted",OracleType.Blob),
                //      new OracleParameter("data_deleted",OracleType.NVarChar,500)

                //};
                //     parametert[0].Value = task_name;
                //     parametert[1].Value = descript;
                //     parametert[2].Value = create_time;
                //     parametert[3].Value = creator;
                //     parametert[4].Value = operatype;
                //     parametert[5].Value = source_table;
                //     parametert[6].Value = target_table;
                //     parametert[7].Value = data;
                //     parametert[8].Value = data_inserted;
                //     parametert[9].Value = data_deleted;
                //     Dictionary<string, string> keyValuest = DbHelperOra.RunProcedure("Prc_Erp_MES_send", parametert);

                int li_count = DBorl.ExecuteSql(" INSERT INTO SYSDEC(task_id,task_name,descript,create_time,creator,operatype,source_table,target_table,data,data_inserted,data_deleted,states) " +
                           " VALUES(seq_down.nextval, '" + task_name + "', '" + descript + "', '" + create_time + "', '" + creator + "', '" + operatype + "', '" + source_table + "', '" + target_table + "', '" + data + "', '" + data_inserted + "', '" + data_deleted + "','NEW')");
                if (li_count <= 0)
                {
                    res = "ERROR:" + "数值错误";
                }
            }
            catch (Exception ex)
            {
                res = "ERROR:" + ex.Message;
            }
            return res;
        }
    }
}
