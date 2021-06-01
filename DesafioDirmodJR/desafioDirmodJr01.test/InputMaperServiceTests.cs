using Microsoft.VisualStudio.TestTools.UnitTesting;
using desafioJunior01.Services;
using desafioJunior01.Services.Implementations;
using System.Collections.Generic;
using System;


namespace desafioJunior01.test{
[TestClass]
public class InputMaperServiceTest
    {

        [TestMethod]
        public void mapThis_shouldBeSuccess()
        {
            //arrange
            string inp = "hola mi amigo como te va" ;
            string expected = "44666555206444026444 46660222666 6 666083308882";

            string pathMap = @"mapaAlfa.json";
            //string pathMap = @"mapaAlfa.txt";

            //IMapService mapGen = new MapService(new StringService(), new FileService());
            IMapService mapGen = new DictJsonMAPService(new FileService());
            Dictionary<char, int> map = mapGen.getMap(pathMap);
            InputMapperService maperService = new InputMapperService(map);

            //act
            string actual = maperService.mapThis(inp);

            //assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        [ExpectedException(typeof(ExpectedException))]
        public void mapThis_shouldThrowMyException()
        {            
            //arrange
            string inp = "HELLO WORLD";
            string pathMap = @"mapaAlfa.json";
            //string pathMap = @"mapaAlfa.txt";

            //IMapService mapGen = new MapService(new StringService(), new FileService());
            IMapService mapGen = new DictJsonMAPService(new FileService());
            Dictionary<char, int> map = mapGen.getMap(pathMap);
            InputMapperService maperService = new InputMapperService(map);

            //act
            string actual = maperService.mapThis(inp);

            //assert
        }
    }
}