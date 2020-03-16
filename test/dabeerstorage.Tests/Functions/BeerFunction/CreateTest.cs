using System.Net;
using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Core;
using Amazon.Lambda.TestUtilities;
using AutoFixture.Xunit2;
using DaBeerStorage.Functions;
using DaBeerStorage.Functions.ApiModels.Beer;
using DaBeerStorage.Functions.Interfaces;
using DaBeerStorage.Functions.Validators.ApiModels.Beer;
using FluentValidation.Results;
using Moq;
using Newtonsoft.Json;
using Shouldly;
using Xunit;

namespace DaBeerStorage.Tests.Functions.BeerFunction
{
    public class CreateTest : BeerFunctionTest
    {
        public CreateTest() : base() { }

        [Fact]
        public void ShouldReturnBadRequest_WhenRequestIsNull() =>
            ReturnBadRequest_WhenRequestIsNull(mut.Create).StatusCode.ShouldBe(BadRequest);

        [Fact]
        public void ShouldReturnBadRequest_WhenRequestModelIsNull() =>
            ReturnBadRequest_WhenModeInRequestIsNull(mut.Create).StatusCode.ShouldBe(BadRequest);

        [Fact]
        public void Should_Call_CheckRequest() => Call_CheckRequest<Create,CreateValidator>(moqFunction.Object.Create);

        [Theory,AutoData]
        public void Should_Return_Ok_When_Request_Is_Valid(Create createObject)
        {
            Return_Ok_When_Request_Is_Valid<Create,CreateValidator>(mut.Create,createObject);
        }

        [Theory,AutoData]
        public void Should_Return_ErrorList_When_Object_Has_Invalid_Data(Create createObject)
        {
            createObject.Description = null;
            Return_BadRequest_WhenRequestIsValid<Create,CreateValidator>(mut.Create,createObject);
        }
    }
}