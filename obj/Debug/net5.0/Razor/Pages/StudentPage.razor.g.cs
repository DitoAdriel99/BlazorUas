#pragma checksum "C:\MATAKULIAH\FRONTEND\UAS\Pages\StudentPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "108278536a1a01185c542266cd80c0301e1115dd"
// <auto-generated/>
#pragma warning disable 1591
namespace UAS.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\MATAKULIAH\FRONTEND\UAS\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\MATAKULIAH\FRONTEND\UAS\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\MATAKULIAH\FRONTEND\UAS\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\MATAKULIAH\FRONTEND\UAS\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\MATAKULIAH\FRONTEND\UAS\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\MATAKULIAH\FRONTEND\UAS\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\MATAKULIAH\FRONTEND\UAS\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\MATAKULIAH\FRONTEND\UAS\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\MATAKULIAH\FRONTEND\UAS\_Imports.razor"
using UAS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\MATAKULIAH\FRONTEND\UAS\_Imports.razor"
using UAS.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/studentpage")]
    public partial class StudentPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>List Of Student</h2>\r\n ");
            __builder.AddMarkupContent(1, "<button class=\"btn btn-primary\" onclick=\"window.location.href=\'/addStudent\'\">Tambah Mahasiswa</button>\r\n ");
            __builder.AddMarkupContent(2, "<a><br></a>\r\n");
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table table-striped");
            __builder.AddMarkupContent(5, "<thead><tr><th>Nim</th>\r\n            <th>Nama Belakang</th>\r\n            <th>Nama Depan</th>\r\n            <th>Tanggal Masuk</th>\r\n            <th></th></tr></thead>\r\n    ");
            __builder.OpenElement(6, "tbody");
#nullable restore
#line 17 "C:\MATAKULIAH\FRONTEND\UAS\Pages\StudentPage.razor"
         foreach (var stud in Students)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "tr");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 20 "C:\MATAKULIAH\FRONTEND\UAS\Pages\StudentPage.razor"
                     stud.studentID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n                ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 21 "C:\MATAKULIAH\FRONTEND\UAS\Pages\StudentPage.razor"
                     stud.lastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 22 "C:\MATAKULIAH\FRONTEND\UAS\Pages\StudentPage.razor"
                     stud.firstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 23 "C:\MATAKULIAH\FRONTEND\UAS\Pages\StudentPage.razor"
                     stud.enrollmentDate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.OpenElement(20, "td");
            __builder.OpenElement(21, "a");
            __builder.AddAttribute(22, "href", 
#nullable restore
#line 25 "C:\MATAKULIAH\FRONTEND\UAS\Pages\StudentPage.razor"
                           $"detailpage/{stud.studentID}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(23, "class", "btn btn-outline-primary");
            __builder.AddContent(24, "details");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.AddMarkupContent(26, "<a href=\"/enrollment\" class=\"btn btn-outline-warning\">enroll</a>\r\n                ");
            __builder.OpenElement(27, "a");
            __builder.AddAttribute(28, "href", 
#nullable restore
#line 27 "C:\MATAKULIAH\FRONTEND\UAS\Pages\StudentPage.razor"
                           $"editstudent/{stud.studentID}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(29, "class", "btn btn-outline-info");
            __builder.AddContent(30, "edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                ");
            __builder.OpenElement(32, "a");
            __builder.AddAttribute(33, "href", 
#nullable restore
#line 28 "C:\MATAKULIAH\FRONTEND\UAS\Pages\StudentPage.razor"
                           $"deletestudent/{stud.studentID}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(34, "class", "btn btn-outline-dark");
            __builder.AddContent(35, "delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 30 "C:\MATAKULIAH\FRONTEND\UAS\Pages\StudentPage.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
