using System;

using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Queo.Commons.Tests
{
    [TestFixture]
    public class ObjectsTest
    {
        [Test]
        public void TestGetPropertyNamePathWithTwoStages()
        {
            string expectedName = "Foo.Birthday";
            string actualPropertyNamePath = Objects.GetPropertyPath<Boo>(x => x.Foo.Birthday);
            ClassicAssert.AreEqual(expectedName, actualPropertyNamePath);
        }

        [Test]
        public void TestGetPropertyNamePathForDirectProperty()
        {
            string expectedName = "Birthday";
            string actualPropertyNamePath = Objects.GetPropertyPath<Foo>(x => x.Birthday);
            ClassicAssert.AreEqual(expectedName, actualPropertyNamePath);
        }

        [Test]
        public void TestGetPropertyNamePathWith4Stages()
        {
            string expectedName = "Foo.Parent.Parent.Name";
            string actualPropertyNamePath = Objects.GetPropertyPath<Boo>(x => x.Foo.Parent.Parent.Name);
            ClassicAssert.AreEqual(expectedName, actualPropertyNamePath);
        }

        [Test]
        public void TestGetPropertyNameObject()
        {
            string expectedPropertyName = "Parent";
            string actualPropertyName = Objects.GetPropertyName<Foo>(x => x.Parent);
            ClassicAssert.AreEqual(expectedPropertyName, actualPropertyName);
        }

        [Test]
        public void TestGetPropertyNameStructOnlyGetter()
        {
            string expectedPropertyName = "Birthday";
            string actualPropertyName = Objects.GetPropertyName<Foo>(x => x.Birthday);
            ClassicAssert.AreEqual(expectedPropertyName, actualPropertyName);
        }

        [Test]
        public void TestGetPropertyNameTypeString()
        {
            string expectedPropertyName = "Name";
            string actualPropertyName = Objects.GetPropertyName<Foo>(x => x.Name);
            ClassicAssert.AreEqual(expectedPropertyName, actualPropertyName);
        }

        [Test]
        public void TestGetPropertyNameValueTypeInt()
        {
            string expectedPropertyName = "Id";
            string actualPropertyName = Objects.GetPropertyName<Foo>(x => x.Id);
            ClassicAssert.AreEqual(expectedPropertyName, actualPropertyName);
        }

        [Test]
        public void TestGetPropertyNameWithPathExpression()
        {
            string expectedPropertyName = "Name";
            string actualPropertyName = Objects.GetPropertyName<Foo>(x => x.Parent.Parent.Parent.Name);
            ClassicAssert.AreEqual(expectedPropertyName, actualPropertyName);
        }
    }

    class Foo
    {
        readonly DateTime _birthday = new DateTime(2014, 8, 4);
        private int _id;
        private string _name;
        private Foo _parent;

        public DateTime Birthday
        {
            get { return _birthday; }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Foo Parent
        {
            set { _parent = value; }
            get { return null; }
        }
    }

    class Boo
    {
        private readonly Foo _foo = new Foo();

        public Foo Foo
        {
            get { return _foo; }
        }
    }
}
