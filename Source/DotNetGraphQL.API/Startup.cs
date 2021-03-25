using DotNetGraphQL.API.Schemas;
using GraphQL.Server;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace DotNetGraphQL.API
{
    public class Startup
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.Configure<KestrelServerOptions>(options => options.AllowSynchronousIO = true);

            services.AddSingleton<ContactGraphType>();
            services.AddSingleton<ErrorGraphType>();
            services.AddSingleton<HistoryGraphType>();
            services.AddSingleton<IdentityGraphType>();
            services.AddSingleton<PropertyGraphType>();
            services.AddSingleton<ScheduleGraphType>();
            services.AddSingleton<TimeFactorGraphType>();
            services.AddSingleton<TimeSpecGraphType>();
            services.AddSingleton<TranslationGraphType>();
            services.AddSingleton<VariantGraphType>();
            services.AddSingleton<VersionGraphType>();
            services.AddSingleton<AgreementGraphType>();
            services.AddSingleton<AgreementContactGraphType>();
            services.AddSingleton<AgreementPartyGraphType>();
            services.AddSingleton<DocumentGraphType>();
            services.AddSingleton<PartyGraphType>();
            services.AddSingleton<AttributeGraphType>();
            services.AddSingleton<ClauseGraphType>();
            services.AddSingleton<ClauseObligationGraphType>();
            services.AddSingleton<ElementGraphType>();
            services.AddSingleton<EventGraphType>();
            services.AddSingleton<ObligationGraphType>();
            services.AddSingleton<ClauseSchemaGraphType>();
            services.AddSingleton<ViewGraphType>();
            services.AddSingleton<ActionGraphType>();
            services.AddSingleton<ComponentGraphType>();
            services.AddSingleton<ComponentPartyGraphType>();
            services.AddSingleton<ComponentSpecGraphType>();
            services.AddSingleton<IntegrationGraphType>();
            services.AddSingleton<TemplateGraphType>();
            services.AddSingleton<AmountGraphType>();
            services.AddSingleton<AnnotationGraphType>();
            services.AddSingleton<AttachmentGraphType>();
            services.AddSingleton<AuthorGraphType>();
            services.AddSingleton<BindingGraphType>();
            services.AddSingleton<CompletionGraphType>();
            services.AddSingleton<DurationGraphType>();
            services.AddSingleton<DurationSpecGraphType>();
            services.AddSingleton<EntityGraphType>();
            services.AddSingleton<LinkGraphType>();
            services.AddSingleton<OccurrenceGraphType>();
            services.AddSingleton<PeriodGraphType>();
            services.AddSingleton<PeriodSpecGraphType>();
            services.AddSingleton<PositionGraphType>();
            services.AddSingleton<PriceGraphType>();
            services.AddSingleton<QuantityGraphType>();
            services.AddSingleton<RangeGraphType>();
            services.AddSingleton<RatioGraphType>();
            services.AddSingleton<RepeatGraphType>();
            services.AddSingleton<TimingGraphType>();
            services.AddSingleton<ValueGraphType>();
            services.AddSingleton<AddressGraphType>();
            services.AddSingleton<OrganizationGraphType>();
            services.AddSingleton<PersonGraphType>();
            services.AddSingleton<TemplateSpecGraphType>();
            services.AddSingleton<ClauseSpecGraphType>();

            services.AddSingleton<EpisodeEnum>();
            services.AddSingleton<AccessEnum>();
            services.AddSingleton<ClassEnum>();
            services.AddSingleton<CompletionStatusEnum>();
            services.AddSingleton<CountryEnum>();
            services.AddSingleton<CurrencyEnum>();
            services.AddSingleton<FormatTypeEnum>();
            services.AddSingleton<FrequencyEnum>();
            services.AddSingleton<FunctionEnum>();
            services.AddSingleton<GenderEnum>();
            services.AddSingleton<HourEnum>();
            services.AddSingleton<IssuePriorityEnum>();
            services.AddSingleton<IssueResolutionEnum>();
            services.AddSingleton<IssueStatusEnum>();
            services.AddSingleton<IssueTypeEnum>();
            services.AddSingleton<LocaleEnum>();
            services.AddSingleton<MessageActionEnum>();
            services.AddSingleton<MessageTypeEnum>();
            services.AddSingleton<MonthEnum>();
            services.AddSingleton<MonthDayEnum>();
            services.AddSingleton<PermissionEnum>();
            services.AddSingleton<PlatformEnum>();
            services.AddSingleton<PrivacyEnum>();
            services.AddSingleton<RoleEnum>();
            services.AddSingleton<RolePermissionEnum>();
            services.AddSingleton<RuleTypeEnum>();
            services.AddSingleton<SeverityEnum>();
            services.AddSingleton<StateEnum>();
            services.AddSingleton<UsageEnum>();
            services.AddSingleton<WeekEnum>();
            services.AddSingleton<WeekDayEnum>();
            services.AddSingleton<ContactRoleEnum>();
            services.AddSingleton<ContactTypeEnum>();
            services.AddSingleton<EventTypeEnum>();
            services.AddSingleton<ViewFormEnum>();
            services.AddSingleton<ViewTypeEnum>();
            services.AddSingleton<ComponentTypeEnum>();
            services.AddSingleton<BindingTypeEnum>();
            services.AddSingleton<EntityStateEnum>();
            services.AddSingleton<EntityTypeEnum>();
            services.AddSingleton<EventTimingEnum>();
            services.AddSingleton<LinkTypeEnum>();
            services.AddSingleton<QuantityComparatorEnum>();
            services.AddSingleton<TimingAbbreviationEnum>();
            services.AddSingleton<UnitsOfTimeEnum>();
            services.AddSingleton<PartyTypeEnum>();

            services.AddSingleton<DogImagesGraphType>();
            services.AddSingleton<StarWarsData>();
            services.AddSingleton<HumanType>();
            services.AddSingleton<HumanInputType>();
            services.AddSingleton<DroidType>();
            services.AddSingleton<CharacterInterface>();
            services.AddSingleton<EpisodeEnum>();
            services.AddSingleton<ImagesQuery>();
            services.AddSingleton<StarWarsMutation>();
            services.AddSingleton<ImagesSchema>();
            
            services.AddGraphQL(options => options.EnableMetrics = false)
	            .AddErrorInfoProvider(options => options.ExposeExceptionStackTrace = true)
	            .AddNewtonsoftJson();

            services.AddCors(options =>
                                options.AddPolicy("AllowAll", p => p.AllowAnyOrigin()
                                .AllowAnyMethod()
                                .AllowAnyHeader()));
            services.AddLogging(builder => builder.AddConsole());
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        }

        public static void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();

            app.UseCors("AllowAll");

            app.UseDefaultFiles();
            app.UseStaticFiles();

            app.UseGraphQL<ImagesSchema>("/");
        }
    }
}
