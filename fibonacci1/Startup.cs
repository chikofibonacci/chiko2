using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace fibonacci1
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        { }
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            app.MapWhen(context => { return context.Request.Query.ContainsKey("index") && context.Request.Query["index"] == "1"; }, HandleId1);

            app.MapWhen(context => { return context.Request.Query.ContainsKey("index") && context.Request.Query["index"] == "2"; }, HandleId2);

            app.MapWhen(context => { return context.Request.Query.ContainsKey("index") && context.Request.Query["index"] == "3"; }, HandleId3);

            app.MapWhen(context => { return context.Request.Query.ContainsKey("index") && context.Request.Query["index"] == "4"; }, HandleId4);

            app.MapWhen(context => { return context.Request.Query.ContainsKey("index") && context.Request.Query["index"] == "5"; }, HandleId5);

            app.MapWhen(context => { return context.Request.Query.ContainsKey("index") && context.Request.Query["index"] == "6"; }, HandleId6);

            app.MapWhen(context => { return context.Request.Query.ContainsKey("index") && context.Request.Query["index"] == "7"; }, HandleId7);

            app.MapWhen(context => { return context.Request.Query.ContainsKey("index") && context.Request.Query["index"] == "8"; }, HandleId8);

            app.MapWhen(context => { return context.Request.Query.ContainsKey("index") && context.Request.Query["index"] == "9"; }, HandleId9);

            app.MapWhen(context => { return context.Request.Query.ContainsKey("index") && context.Request.Query["index"] == "10"; }, HandleId10);

            app.MapWhen(context => { return context.Request.Query.ContainsKey("index") && context.Request.Query["index"] == "11"; }, HandleId11);

            app.MapWhen(context => { return context.Request.Query.ContainsKey("index") && context.Request.Query["index"] == "12"; }, HandleId12);

            app.MapWhen(context => { return context.Request.Query.ContainsKey("index") && context.Request.Query["index"] == "13"; }, HandleId13);

            app.MapWhen(context => { return context.Request.Query.ContainsKey("index") && context.Request.Query["index"] == "14"; }, HandleId14);

            app.MapWhen(context => { return context.Request.Query.ContainsKey("index") && context.Request.Query["index"] == "15"; }, HandleId15);

            app.MapWhen(context => { return context.Request.Query.ContainsKey("index") && context.Request.Query["index"] == "16"; }, HandleId16);

            app.MapWhen(context => { return context.Request.Query.ContainsKey("index") && context.Request.Query["index"] == "17"; }, HandleId17);

            app.MapWhen(context => { return context.Request.Query.ContainsKey("index") && context.Request.Query["index"] == "18"; }, HandleId18);

            app.MapWhen(context => { return context.Request.Query.ContainsKey("index") && context.Request.Query["index"] == "19"; }, HandleId19);

            app.MapWhen(context => { return context.Request.Query.ContainsKey("index") && context.Request.Query["index"] == "20"; }, HandleId20);

            app.MapWhen(context => { return context.Request.Query.ContainsKey("index") && context.Request.Query["index"] == "21"; }, HandleId21);

            app.MapWhen(context => { return context.Request.Query.ContainsKey("index") && context.Request.Query["index"] == "22"; }, HandleId22);

            app.MapWhen(context => { return context.Request.Query.ContainsKey("index") && context.Request.Query["index"] == "23"; }, HandleId23);

            app.MapWhen(context => { return context.Request.Query.ContainsKey("index") && context.Request.Query["index"] == "24"; }, HandleId24);

            app.MapWhen(context => { return context.Request.Query.ContainsKey("index") && context.Request.Query["index"] == "25"; }, HandleId25);

            app.MapWhen(context => { return context.Request.Query.ContainsKey("index") && context.Request.Query["index"] == "26"; }, HandleId26);

            app.MapWhen(context => { return context.Request.Query.ContainsKey("index") && context.Request.Query["index"] == "27"; }, HandleId27);

            app.MapWhen(context => { return context.Request.Query.ContainsKey("index") && context.Request.Query["index"] == "28"; }, HandleId28);

            app.MapWhen(context => { return context.Request.Query.ContainsKey("index") && context.Request.Query["index"] == "29"; }, HandleId29);

            app.MapWhen(context => { return context.Request.Query.ContainsKey("index") && context.Request.Query["index"] == "30"; }, HandleId30);

            app.MapWhen(context => { return context.Request.Query.ContainsKey("index") && context.Request.Query["index"] == "31"; }, HandleId31);

            app.MapWhen(context => { return context.Request.Query.ContainsKey("index") && context.Request.Query["index"] == "32"; }, HandleId32);

            app.MapWhen(context => { return context.Request.Query.ContainsKey("index") && context.Request.Query["index"] == "33"; }, HandleId33);

            app.MapWhen(context => { return context.Request.Query.ContainsKey("index") && context.Request.Query["index"] == "34"; }, HandleId34);

            app.MapWhen(context => { return context.Request.Query.ContainsKey("index") && context.Request.Query["index"] == "35"; }, HandleId35);

            app.MapWhen(context => { return context.Request.Query.ContainsKey("index") && context.Request.Query["index"] == "36"; }, HandleId36);

            app.MapWhen(context => { return context.Request.Query.ContainsKey("index") && context.Request.Query["index"] == "37"; }, HandleId37);

            app.MapWhen(context => { return context.Request.Query.ContainsKey("index") && context.Request.Query["index"] == "38"; }, HandleId38);

            app.MapWhen(context => { return context.Request.Query.ContainsKey("index") && context.Request.Query["index"] == "39"; }, HandleId39);

            app.MapWhen(context => { return context.Request.Query.ContainsKey("index") && context.Request.Query["index"] == "40"; }, HandleId40);

            app.Run(async (context) => { await context.Response.WriteAsync("Error"); });
        }
        private static void HandleId1(IApplicationBuilder app) { app.Run(async context => { await context.Response.WriteAsync("1"); }); }

        private static void HandleId2(IApplicationBuilder app) { app.Run(async context => { await context.Response.WriteAsync("1"); }); }

        private static void HandleId3(IApplicationBuilder app) { app.Run(async context => { await context.Response.WriteAsync("2"); }); }

        private static void HandleId4(IApplicationBuilder app) { app.Run(async context => { await context.Response.WriteAsync("3"); }); }

        private static void HandleId5(IApplicationBuilder app) { app.Run(async context => { await context.Response.WriteAsync("5"); }); }

        private static void HandleId6(IApplicationBuilder app) { app.Run(async context => { await context.Response.WriteAsync("8"); }); }

        private static void HandleId7(IApplicationBuilder app) { app.Run(async context => { await context.Response.WriteAsync("13"); }); }

        private static void HandleId8(IApplicationBuilder app) { app.Run(async context => { await context.Response.WriteAsync("21"); }); }

        private static void HandleId9(IApplicationBuilder app) { app.Run(async context => { await context.Response.WriteAsync("34"); }); }

        private static void HandleId10(IApplicationBuilder app) { app.Run(async context => { await context.Response.WriteAsync("55"); }); }

        private static void HandleId11(IApplicationBuilder app) { app.Run(async context => { await context.Response.WriteAsync("89"); }); }

        private static void HandleId12(IApplicationBuilder app) { app.Run(async context => { await context.Response.WriteAsync("114"); }); }

        private static void HandleId13(IApplicationBuilder app) { app.Run(async context => { await context.Response.WriteAsync("233"); }); }

        private static void HandleId14(IApplicationBuilder app) { app.Run(async context => { await context.Response.WriteAsync("377"); }); }

        private static void HandleId15(IApplicationBuilder app) { app.Run(async context => { await context.Response.WriteAsync("610"); }); }

        private static void HandleId16(IApplicationBuilder app) { app.Run(async context => { await context.Response.WriteAsync("987"); }); }

        private static void HandleId17(IApplicationBuilder app) { app.Run(async context => { await context.Response.WriteAsync("1597"); }); }

        private static void HandleId18(IApplicationBuilder app) { app.Run(async context => { await context.Response.WriteAsync("2584"); }); }

        private static void HandleId19(IApplicationBuilder app) { app.Run(async context => { await context.Response.WriteAsync("4181"); }); }

        private static void HandleId20(IApplicationBuilder app) { app.Run(async context => { await context.Response.WriteAsync("6765"); }); }

        private static void HandleId21(IApplicationBuilder app) { app.Run(async context => { await context.Response.WriteAsync("10946"); }); }

        private static void HandleId22(IApplicationBuilder app) { app.Run(async context => { await context.Response.WriteAsync("17711"); }); }

        private static void HandleId23(IApplicationBuilder app) { app.Run(async context => { await context.Response.WriteAsync("28657"); }); }

        private static void HandleId24(IApplicationBuilder app) { app.Run(async context => { await context.Response.WriteAsync("46368"); }); }

        private static void HandleId25(IApplicationBuilder app) { app.Run(async context => { await context.Response.WriteAsync("75025"); }); }

        private static void HandleId26(IApplicationBuilder app) { app.Run(async context => { await context.Response.WriteAsync("121393"); }); }

        private static void HandleId27(IApplicationBuilder app) { app.Run(async context => { await context.Response.WriteAsync("196418"); }); }

        private static void HandleId28(IApplicationBuilder app) { app.Run(async context => { await context.Response.WriteAsync("317811"); }); }

        private static void HandleId29(IApplicationBuilder app) { app.Run(async context => { await context.Response.WriteAsync("514229"); }); }

        private static void HandleId30(IApplicationBuilder app) { app.Run(async context => { await context.Response.WriteAsync("832040"); }); }

        private static void HandleId31(IApplicationBuilder app) { app.Run(async context => { await context.Response.WriteAsync("1346269"); }); }

        private static void HandleId32(IApplicationBuilder app) { app.Run(async context => { await context.Response.WriteAsync("2178309"); }); }

        private static void HandleId33(IApplicationBuilder app) { app.Run(async context => { await context.Response.WriteAsync("3524578"); }); }

        private static void HandleId34(IApplicationBuilder app) { app.Run(async context => { await context.Response.WriteAsync("5702887"); }); }

        private static void HandleId35(IApplicationBuilder app) { app.Run(async context => { await context.Response.WriteAsync("9227465"); }); }

        private static void HandleId36(IApplicationBuilder app) { app.Run(async context => { await context.Response.WriteAsync("14930352"); }); }

        private static void HandleId37(IApplicationBuilder app) { app.Run(async context => { await context.Response.WriteAsync("24157817"); }); }

        private static void HandleId38(IApplicationBuilder app) { app.Run(async context => { await context.Response.WriteAsync("39088169"); }); }

        private static void HandleId39(IApplicationBuilder app) { app.Run(async context => { await context.Response.WriteAsync("63245986"); }); }

        private static void HandleId40(IApplicationBuilder app) { app.Run(async context => { await context.Response.WriteAsync("102334155"); }); }
    }
}