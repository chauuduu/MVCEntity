#pragma checksum "C:\Users\Admin\source\repos\MVCEFA\MVC\AppCrud\Views\Customer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d773ea0a8164a15b563f7b14cd30ad13cc293d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Index), @"mvc.1.0.view", @"/Views/Customer/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Admin\source\repos\MVCEFA\MVC\AppCrud\Views\_ViewImports.cshtml"
using AppCrud;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\source\repos\MVCEFA\MVC\AppCrud\Views\_ViewImports.cshtml"
using AppCrud.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d773ea0a8164a15b563f7b14cd30ad13cc293d5", @"/Views/Customer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4805470b98547d8aef3dcc1d04c248407270cd41", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Customer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AppCrud.ViewModel.CustomerViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Admin\source\repos\MVCEFA\MVC\AppCrud\Views\Customer\Index.cshtml"
  
    Layout = "/Views/Shared/_Layout.cshtml";
    ViewData["Title"] = "Customer";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n\r\n    <div class=\"row\">\r\n");
            WriteLiteral(@"        <h2> Customer </h2>
        <div class=""container text-left"">
        <div class=""input-group"" style=""width: 100%; max-width: 300px;"">
            <input type=""text"" class=""form-control border-0"" id=""keyword"" placeholder=""Enter Keyword"">
            <div class=""input-group-append"">
                <button class=""input-group-text bg-primary text-dark border-0 px-3"" type=""button"" onclick=""search()"">
                    <i class=""fa fa-search""></i>
                </button>
            </div>
        </div>
        </div>
        <div class=""container text-right"">
            <button type=""button"" class=""btn btn-success btn-lg float-end"" data-toggle=""modal"" data-target=""#myModal"">
                <i class=""fa-solid fa-plus""></i>
            </button>
        </div>
        <table class=""table"">
            <thead>
                <tr>
                    <th scope=""col"">Id</th>
                    <th scope=""col"">Full Name</th>
                    <th scope=""col"">Birthday</th>
     ");
            WriteLiteral(@"               <th scope=""col"">Date</th>
                    <th scope=""col"">Phone</th>
                    <th scope=""col"">Address</th>
                    <th scope=""col"">Email</th>
                    <th colspan=""2"">Action</th>
                </tr>
            </thead>
            <tbody id=""bodyContent"">
            </tbody>
            <div id=""renderUpdate"">
            </div>
        </table>

        <div class=""modal"" id=""myModal"">
            <div class=""modal-dialog modal-dialog-centered"">
                <div class=""modal-content"">

                    <!-- Modal Header -->
                    <div class=""modal-header"">
                        <h4 class=""modal-title"">Add Customer</h4>
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                            <span aria-hidden=""true"">&times;</span>
                        </button>
                    </div>

                    <!-- Modal body -->
                   ");
            WriteLiteral(@" <div class=""modal-body"">
                        <div class=""form-group"">
                            <div class=""mb-3 mt-3"">
                                <label for=""txtname"" class=""form-label"">Full Name : </label>
                                <input type=""text"" class=""form-control"" id=""txtname"" placeholder=""Enter Name"" name=""txtname"" required>
                                <label for=""txtbirthday"" class=""form-label"">Birthday : </label>
                                <input type=""date"" class=""form-control"" id=""txtbirthday"" placeholder=""Enter Birthday"" name=""txtbirthday"">

                                <label for=""txtphone"" class=""form-label"">Phone : </label>
                                <input type=""text"" class=""form-control"" id=""txtphone"" placeholder=""Enter Phone"" name=""txtphone"">

                                <label for=""txtaddress"" class=""form-label"">Address : </label>
                                <input type=""text"" class=""form-control"" id=""txtaddress"" placeholder=""Enter A");
            WriteLiteral(@"ddress"" name=""txtaddress"">

                                <label for=""txtemail"" class=""form-label"">Email : </label>
                                <input type=""email"" class=""form-control"" id=""txtemail"" placeholder=""Enter Email"" name=""txtemail"">
                            </div>
                            <button type=""button"" class=""btn btn-primary"" onclick=""Add()"">Submit</button>
                        </div>
                    </div>
                </div>

            </div>
        </div>
    </div>
</div>
<script src=""https://momentjs.com/downloads/moment.js""></script>
<script src=""https://code.jquery.com/jquery-3.6.3.js"" integrity=""sha256-nQLuAZGRRcILA+6dMBOvcRh5Pe310sBpanc6+QBmyVM="" crossorigin=""anonymous""></script>
<link rel=""stylesheet""
      href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.3.0/css/all.min.css"">
<script>
    const main = async () => {
        var url = '/api/Customer';
        var reponse = await fetch(url);
        var data = await reponse.jso");
            WriteLiteral(@"n();
        renderSlide(data);
    }
    const search=async()=>{
        var key = document.querySelector(""#keyword"").value;
        if (key.trim() == """") var url = '/api/Customer';
        else var url = '/api/Customer/name?name='+key.trim();
        var reponse = await fetch(url);
        var data = await reponse.json();
        renderSlide(data);
    }   
    document.body.onkeydown = function (e) {
        if (e.keyCode == 13)
            search();
    };
    const renderSlide = (data) => {
        var domSlide = document.querySelector(""#bodyContent"")
        var html = '';
        data.forEach((element, index) => {
            var birthdayString = moment(element.birthday).format('DD-MM-YYYY');
            var dateString = moment(element.date).format('DD-MM-YYYY');
            html += `
            <tr>
                <th scope=""row"">${element.id}</th>
                <td>${element.fullName}</td>
                <td>${birthdayString}</td>
                <td>${dateString}</td>
            WriteLiteral(@"
                <td>${element.phone}</td>
                <td>${element.address}</td>
                <td>${element.email}</td>

                <td>
                    <button type=""button"" class=""btn btn-warning"" onclick='renderUpdate(${JSON.stringify(element)})'>
                            <i class=""fa-solid fa-pen-to-square""></i>
                    </button>
                    <button type=""button"" class=""btn btn-danger"" onclick='Delete(${element.id})'>
                            <i class=""fa-regular fa-trash""></i>
                    </button>
                </td>
            </tr>
            `;
        });
        domSlide.innerHTML = html;
    }

    const renderUpdate = (data) => {
        let html = `
            <div class=""modal"" id=""modalUpdate"">
                <div class=""modal-dialog modal-dialog-centered"">
                    <div class=""modal-content"">
                        <!-- Modal Header -->
                        <div class=""modal-header"">
            ");
            WriteLiteral(@"                <h4 class=""modal-title"">Edit TypeClothes</h4>
                            <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                <span aria-hidden=""true"">&times;</span>
                            </button>
                        </div>
                        <!-- Modal body -->

                        <div class=""modal-body"">
                            <div class=""form-group"">
                                <div class=""mb-3 mt-3"">
                                    <label for=""txtid"" class=""form-label"">ID : </label>
                                    <input type=""text"" class=""form-control"" value=""${data.id}"" id=""txtid"" name=""txtid"" readonly>

                                        <label for=""txtname_update"" class=""form-label"">Full Name : </label>
                                        <input type=""text"" class=""form-control"" id=""txtname_update"" value=""${data.fullName}"" placeholder=""Enter Name"" name=""txtname_update"" r");
            WriteLiteral(@"equired>

                                            <label for=""txtbirthday_update"" class=""form-label"">Birthday : </label>
                                            <input type=""date"" class=""form-control"" id=""txtbirthday_update"" placeholder=""Enter Birthday"" name=""txtbirthday_update"">

                                                <label for=""txtdate_update"" class=""form-label"">Created Date  : </label>
                                                <input type=""date"" class=""form-control"" id=""txtdate_update"" placeholder=""Enter Created Date"" name=""txtdate_update"">



                                                    <label for=""txtphone_update"" class=""form-label"">Phone : </label>
                                                    <input type=""text"" class=""form-control"" id=""txtphone_update"" value=""${data.phone}"" placeholder=""Enter Phone"" name=""txtphone_update"">

                                                        <label for=""txtaddress_update"" class=""form-label"">Address : </label>
     ");
            WriteLiteral(@"                                                   <input type=""text"" class=""form-control"" id=""txtaddress_update"" value=""${data.address}"" placeholder=""Enter Address"" name=""txtaddress_update"">

                                                            <label for=""txtemail_update"" class=""form-label"">Email : </label>
                                                            <input type=""email"" class=""form-control"" id=""txtemail_update"" value=""${data.email}"" placeholder=""Enter Email"" name=""txtemail_update"">


                                                            </div>

                                                            <td>
                                                                <button type=""button"" class=""btn btn-primary"" onclick=""Update()"">Submit</button>
                                                            </div>
                                                        </div>
                                                    </div>
                              ");
            WriteLiteral(@"                  </div>
                                            </div>`;
        document.querySelector(""#renderUpdate"").innerHTML = html;
        var timerFormat = moment(data.birthday).format('YYYY-MM-DD');
        $('#txtbirthday_update').val(timerFormat);

        var timerFormat2 = moment(data.date).format('YYYY-MM-DD');
        $('#txtdate_update').val(timerFormat2);

        $('#modalUpdate').modal('show')
    }
    const Add = async () => {
        let fullName = document.querySelector(""#txtname"").value;
        let birthday = document.querySelector(""#txtbirthday"").value;
        let phone = document.querySelector(""#txtphone"").value;
        let address = document.querySelector(""#txtaddress"").value;
        let email = document.querySelector(""#txtemail"").value;
        var birth = new Date(birthday).toJSON();
        var d = new Date();
        var date = d.toJSON();

        let dataSend = {
            fullName: fullName,
            birthday: birth,
            date: da");
            WriteLiteral(@"te,
            phone: phone,
            address: address,
            email: email
        };
        let response = await fetch(""/api/Customer"", {
            method: ""POST"",
            body: JSON.stringify(dataSend),
            headers: {
                'Content-Type': 'application/json',
                'Accept': 'application/json'
            }
        }).then(rs => {
            if (rs.status == 200) {
                alert(""Thêm thành công!!!"");
                main()
            } else {
                console.log(rs);
                console.log(rs.body);
                console.log(rs.json()['message']);
                alert(""Thêm thất bại"");
            }
        })
    }
    const Delete = async (id) => {
        let response = await fetch(""/api/Customer?id="" + id, {
            method: ""DELETE"",
        }).then(rs => {
            if (rs.status == 200) {
                alert(""Xóa thành công!!!"");
                main()
            } else {
                al");
            WriteLiteral(@"ert(""Xóa thất bại"")
            }
        })
    }
    const Update = async () => {
        let id = document.querySelector(""#txtid"").value;
        let fullName = document.querySelector(""#txtname_update"").value;
        let birthday = document.querySelector(""#txtbirthday_update"").value;
        let date = document.querySelector(""#txtdate_update"").value;
        let phone = document.querySelector(""#txtphone_update"").value;
        let address = document.querySelector(""#txtaddress_update"").value;
        let email = document.querySelector(""#txtemail_update"").value;
        var birth = new Date(birthday).toJSON();
        var d = new Date(date).toJSON();
        let dataSend = {
            fullName: fullName,
            birthday: birth,
            date: d,
            phone: phone,
            address: address,
            email: email
        };
        let response = await fetch(""/api/Customer?id="" + id, {
            method: ""PUT"",
            body: JSON.stringify(dataSend),
     ");
            WriteLiteral(@"       headers: {
                'Content-Type': 'application/json',
                'Accept': 'application/json'
            }
        }).then(rs => {
            if (rs.status == 200) {
                alert(""Chỉnh sửa thành công!!!"");
                main()
            } else {
                alert(""Chỉnh sửa thất bại"")
            }
        })
    }
    main()

</script>
");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AppCrud.ViewModel.CustomerViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591