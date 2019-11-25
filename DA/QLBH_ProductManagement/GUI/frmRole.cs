using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTreeList.Nodes;
using QLBH_ProductManagement.BUS;
using QLBH_ProductManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QLBH_ProductManagement.GUI
{
    public partial class frmPhanQuyen : DevExpress.XtraEditors.XtraForm
    {
        public frmPhanQuyen()
        {
            InitializeComponent();
        }

        GroupUserBUS grUserBUS = new GroupUserBUS();
        UserBUS user_BUS = new UserBUS();

        GroupFormBUS grFormBUS = new GroupFormBUS();
        OBFormBUS obFormBUS = new OBFormBUS();
        ChildFormBUS childFormBUS = new ChildFormBUS();
        RuleFormBUS ruleFormBUS = new RuleFormBUS();
        private void frmRole_Load(object sender, EventArgs e)
        {
            List<GroupUser> listGroupUser = new List<GroupUser>();
            listGroupUser = grUserBUS.getGroupUser();  // lấy được các nhóm người dùng


            for(int i = 0; i < listGroupUser.Count; i++)
            {
                List<UserDTO> listUser = new List<UserDTO>();
                listUser = user_BUS.GetUserFromGroup(listGroupUser[i].GR_ID);  // lấy danh sách các User cuar GR đấy
                TreeListNode prarentNode = treeGroupUser.AppendNode(null, null);
                prarentNode.SetValue("vaitrovanguoidung", listGroupUser[i].Group_Name);

                for (int j = 0; j < listUser.Count; j++)
                {
                    TreeListNode childNode1 = null;
                    childNode1 = treeGroupUser.AppendNode(null, prarentNode);
                    childNode1.SetValue("vaitrovanguoidung", listUser[j].NameUser);
                }
            }
            //Hiển thị phần chức năng phân quyền

            // lấy các ID và Name của GroupForm

            List<GroupForm> listGroupForm = new List<GroupForm>();
            listGroupForm = grFormBUS.getGroupForm();

            for(int i = 0; i < listGroupForm.Count; i++)
            {
                TreeListNode prarentNode = listRule.AppendNode(null, null);
                prarentNode.SetValue("chucNang", listGroupForm[i].formName);
                List<OBForm> listOBForm = obFormBUS.getListOBForm(listGroupForm[i].formID); // lấy được OBForm theo nhóm form
                prarentNode.SetValue("All", true);
                prarentNode.SetValue("Add", true);
                prarentNode.SetValue("Access", true);
                prarentNode.SetValue("Nhap", true);
                prarentNode.SetValue("Xuat", true);
                prarentNode.SetValue("In", true);
                prarentNode.SetValue("Delete", true);
                prarentNode.SetValue("Edit", true);


                for (int j = 0; j < listOBForm.Count; j++)
                {
                    TreeListNode childnode1 = null;
                    childnode1 = listRule.AppendNode(null, prarentNode);
                    childnode1.SetValue("chucNang", listOBForm[j].OBForm_Name);
                    childnode1.SetValue("All", true);
                    childnode1.SetValue("Add", true);
                    childnode1.SetValue("Access", true);
                    childnode1.SetValue("Nhap", true);
                    childnode1.SetValue("Xuat", true);
                    childnode1.SetValue("In", true);
                    childnode1.SetValue("Delete", true);
                    childnode1.SetValue("Edit", true);
                    // lấy danh sách các form
                    List<FormChild> listFormChild = childFormBUS.getListOBChild(listOBForm[j].Object_ID);

                    for (int z = 0; z < listFormChild.Count; z++) 
                    {
                        TreeListNode childnode11 = null;
                        childnode11 = listRule.AppendNode(null, childnode1);
                        childnode11.SetValue("chucNang", listFormChild[z].Child_Name);
                        TreeListNode child111 = new TreeListNode();
                        // lấy các quyền truy cập của Form
                        List<RuleForm> listRuleForm = ruleFormBUS.getRuleFormChild(listFormChild[z].OBJECT_CHILD_ID);
                        childnode11.SetValue("All", true);
                        childnode11.SetValue("Access", listRuleForm[0].AllowAccess);
                        childnode11.SetValue("Add", listRuleForm[0].AllowAdd);
                        childnode11.SetValue("Delete", listRuleForm[0].AllowDelete);
                        childnode11.SetValue("Nhap", listRuleForm[0].AllowExport);
                        childnode11.SetValue("Xuat", listRuleForm[0].AllowImport);
                        childnode11.SetValue("In", listRuleForm[0].AllowPrint);
                        childnode11.SetValue("Edit", listRuleForm[0].AllowEdit);

                    }
                }
            }



        }

        List<UserGroupDTO> listUser;
        private void treeGroupUser_RowCellClick(object sender, DevExpress.XtraTreeList.RowCellClickEventArgs e)
        {
            var pra = e.Node.ParentNode;  // lấy node cha
            string namePraNode;
            if (pra == null)
            {
                namePraNode = e.Node.GetValue(0).ToString();
            }
            else
            {
                namePraNode = pra.GetValue(0).ToString();
            }

            List<GroupUser> listGroup = grUserBUS.getGroupUserFromName(namePraNode);
           
            listUser = user_BUS.GetUserGroup(listGroup[0].GR_ID, listGroup[0].Group_Name);
            gridGroupUser.DataSource = listGroup;
        }

        private void gridViewGroupUser_MasterRowEmpty(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e)
        {
            GridView grv = sender as GridView;

            GroupUser user = grv.GetRow(e.RowHandle) as GroupUser;
            if (user != null)
            {
                e.IsEmpty = !listUser.Any(x => x.groupID == user.GR_ID);
            }
        }

        private void gridViewGroupUser_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e)
        {
            GridView grv = sender as GridView;

            GroupUser user = grv.GetRow(e.RowHandle) as GroupUser;
           
                e.ChildList = listUser.Where(x => x.groupID == user.GR_ID).ToList();          
        }

        private void gridViewGroupUser_MasterRowGetRelationCount(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

        private void gridViewGroupUser_MasterRowGetRelationName(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "gridViewDetailUser";
        }

        private void treeGroupUser_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {

        }
    }
}