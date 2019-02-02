using UnityEngine;
// using UnityEngine.TestTools.Utils;
using NUnit.Framework;
using System.Collections;
using UnityEngine.Tilemaps;
using System.Collections.Generic;

public class TestTiles {

    [Test]
    public void TestTilesSimplePasses() {
        List<Tile> testList;
        Tile tileOne = new Tile();
        Tile tileTwo = new Tile();
        tileOne.color = Color.red;
        tileTwo.color = Color.blue;
        testList = new List<Tile>();
        testList.Add(tileOne);
        testList.Add(tileTwo);

        Tiles.SetTiles(testList);
        
        // Use the Assert class to test conditions.
    }

    //// A UnityTest behaves like a coroutine in PlayMode
    //// and allows you to yield null to skip a frame in EditMode
    //[UnityTest]
    //public IEnumerator TestTilesWithEnumeratorPasses() {
    //    // Use the Assert class to test conditions.
    //    // yield to skip a frame
    //    yield return null;
    //}
}
