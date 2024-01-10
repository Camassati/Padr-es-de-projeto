//Client
using CompositePatternC_;

GitComponent mainBranch = new Branch("main");
GitComponent commitToMain1 = new Commit("82a79d4");
GitComponent commitToMain2 = new Commit("1c053ff");
GitComponent commitToMain3 = new Commit("1b5f943");
GitComponent commitToMain4 = new Commit("b1f9423");
mainBranch.Add(commitToMain1);
mainBranch.Add(commitToMain2);
mainBranch.Add(commitToMain3);
mainBranch.Add(commitToMain4);
mainBranch.Remove(commitToMain4);

GitComponent smallFeature = new Branch("small-geature");
mainBranch.Add(smallFeature);

GitComponent commitToSmallFeature1 = new Commit("22f71d3");
smallFeature.Add(commitToSmallFeature1);

GitComponent bigFeature = new Branch("big-feature");
mainBranch.Add(bigFeature);

GitComponent commitTobigFeature1 = new Commit("42a79d4");
GitComponent commitTobigFeature2 = new Commit("0c053ff");
GitComponent commitTobigFeature3 = new Commit("2v5f943");
GitComponent commitTobigFeature4 = new Commit("c1f9423");
GitComponent commitTobigFeature5 = new Commit("7b5f943");
GitComponent commitTobigFeature6 = new Commit("d1f9423");
bigFeature.Add(commitTobigFeature1);
bigFeature.Add(commitTobigFeature2);
bigFeature.Add(commitTobigFeature3);
bigFeature.Add(commitTobigFeature4);
bigFeature.Add(commitTobigFeature5);
bigFeature.Add(commitTobigFeature6);

Console.WriteLine("smallFeature feature Commit Histoy:");
Console.WriteLine("----------------------------------");
smallFeature.ShowDetail();

Console.WriteLine("\nBigFeature feature Commit Histoy:");
Console.WriteLine("----------------------------------");
bigFeature.ShowDetail();

Console.WriteLine("\nFull Commit Histoy:");
Console.WriteLine("----------------------------------");
mainBranch.ShowDetail();