using System.Text;

//namespace Server.Items
//{
//    public class Pareo : BaseWaist
//    {
//public override bool ResizeOnFly => true;
//public override int HumanID => 0x1516;
//public override int DwarvenID => 0x24B7;

//        [Constructable]
//        public Pareo() : this(0)
//        {
//        }

//        [Constructable]
//        public Pareo(int hue) : base(0x3BD8, hue)
//        {
//            Name = "Pareo";
//            Weight = 3.0;
//        }

//        public Pareo(Serial serial) : base(serial)
//        {
//        }

//        public override void Serialize(GenericWriter writer)
//        {
//            base.Serialize(writer);

//            writer.Write(0); // version
//        }

//        public override void Deserialize(GenericReader reader)
//        {
//            base.Deserialize(reader);

//            int version = reader.ReadInt();

//        }
//    }
//}

namespace ClothGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LayerCombo.DataSource = Enum.GetValues(typeof(Layer));
        }

        private void IsDwarfCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (IsDwarfCheck.Checked)
            {
                DwarfTb.Text = "";
                DwarfTb.Visible = true;
            }
            else
            {
                DwarfTb.Visible = false;
            }
        }

        private Dictionary<Layer, string> LayerBaseClasses = new Dictionary<Layer, string>()
        {
            {Layer.Shoes , "BaseShoes" },
            {Layer.Pants , "BasePants" },
            {Layer.Shirt , "BaseShirt" },
            {Layer.Helm , "BaseHat" },
        };

        private string GetClassBaseName(Layer layer)
        {
            if (LayerBaseClasses.TryGetValue(layer, out string className))
            {
                return className;
            }
            else
            {
                return $"Base{layer}";
            }
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            var isDwarf = IsDwarfCheck.Checked;
            var isNameSpace = NamespaceCB.Checked;

            var code = new StringBuilder();

            if (isNameSpace)
            {
                code.AppendLine("namespace Server.Items");

                code.AppendLine("{");
            }

            var currentLayer = (Layer)LayerCombo.SelectedItem;

            //Item name
            code.AppendLine($"public class {NameTB.Text} : {GetClassBaseName(currentLayer)}");
            code.AppendLine("{");
            if (isDwarf)
            {
                code.AppendLine("public override bool ResizeOnFly => true;");
                code.AppendLine($"public override int HumanID => {HumanTb.Text};");
                code.AppendLine($"public override int DwarvenID => {DwarfTb.Text};");
            }

            if (!ArmorCheck.Checked)
            {
                code.AppendLine("[Constructable]");

                code.AppendLine($"public {NameTB.Text}() : this(0)");
                code.AppendLine("{");
                code.AppendLine("}");

                code.AppendLine("[Constructable]");
                code.AppendLine($"public {NameTB.Text}(int hue) : base({HumanTb.Text}, hue)");
                code.AppendLine("{");
                code.AppendLine($"   Name = \"{itemNameTb.Text}\";");
                code.AppendLine($"   Weight = 1.0;");
                code.AppendLine("}");
            }
            else
            {
                code.AppendLine("[Constructable]");
                code.AppendLine($"public {NameTB.Text}() : base({HumanTb.Text})");
                code.AppendLine("{");
                code.AppendLine($"   Name = \"{itemNameTb.Text}\";");
                code.AppendLine($"   Weight = 1.0;");
                code.AppendLine($"   Layer = Layer.{currentLayer};");
                code.AppendLine("}");
            }

            code.AppendLine($"public {NameTB.Text}(Serial serial) : base(serial)");
            code.AppendLine("{");
            code.AppendLine("}");

            //        public Pareo(Serial serial) : base(serial)
            //        {
            //        }

            code.AppendLine("public override void Serialize(GenericWriter writer)");
            code.AppendLine("{");
            code.AppendLine("   base.Serialize(writer);");
            code.AppendLine("   writer.Write(0); // version");
            code.AppendLine("}");

            code.AppendLine("public override void Deserialize(GenericReader reader)");
            code.AppendLine("{");
            code.AppendLine("   base.Deserialize(reader);");
            code.AppendLine("   int version = reader.ReadInt();");
            code.AppendLine("}");

            code.AppendLine("}");

            if (isNameSpace)
            {
                code.AppendLine("}");
            }

            //        public override void Serialize(GenericWriter writer)
            //        {
            //            base.Serialize(writer);

            //            writer.Write(0); // version
            //        }

            //        public override void Deserialize(GenericReader reader)
            //        {
            //            base.Deserialize(reader);

            //            int version = reader.ReadInt();

            //        }

            //code.AppendLine("{");
            //code.AppendLine("}");

            CodeTextBox.Text = code.ToString();
        }
    }

    public enum Layer : byte
    {
        /// <summary>
        /// One handed weapon.
        /// </summary>
        OneHanded = 0x01,

        /// <summary>
        /// Two handed weapon or shield.
        /// </summary>
        TwoHanded = 0x02,

        /// <summary>
        /// Shoes.
        /// </summary>
        Shoes = 0x03,

        /// <summary>
        /// Pants.
        /// </summary>
        Pants = 0x04,

        /// <summary>
        /// Shirts.f
        /// </summary>
        Shirt = 0x05,

        /// <summary>
        /// Helmets, hats, and masks.
        /// </summary>
        Helm = 0x06,

        /// <summary>
        /// Gloves.
        /// </summary>
        Gloves = 0x07,

        /// <summary>
        /// Rings.
        /// </summary>
        Ring = 0x08,

        /// <summary>
        /// Unused.
        /// </summary>
        Unused_x9 = 0x09,

        /// <summary>
        /// Gorgets and necklaces.
        /// </summary>
        Neck = 0x0A,

        /// <summary>
        /// Hair.
        /// </summary>
        Hair = 0x0B,

        /// <summary>
        /// Half aprons.
        /// </summary>
        Waist = 0x0C,

        /// <summary>
        /// Torso, inner layer.
        /// </summary>
        InnerTorso = 0x0D,

        /// <summary>
        /// Bracelets.
        /// </summary>
        Bracelet = 0x0E,

        /// <summary>
        /// Unused.
        /// </summary>
        Unused_xF = 0x0F,

        /// <summary>
        /// Beards and mustaches.
        /// </summary>
        FacialHair = 0x10,

        /// <summary>
        /// Torso, outer layer.
        /// </summary>
        MiddleTorso = 0x11,

        /// <summary>
        /// Earings.
        /// </summary>
        Earrings = 0x12,

        /// <summary>
        /// Arms and sleeves.
        /// </summary>
        Arms = 0x13,

        /// <summary>
        /// Cloaks.
        /// </summary>
        Cloak = 0x14,

        /// <summary>
        /// Backpacks.
        /// </summary>
        Backpack = 0x15,

        /// <summary>
        /// Torso, outer layer.
        /// </summary>
        OuterTorso = 0x16,

        /// <summary>
        /// Leggings, outer layer.
        /// </summary>
        OuterLegs = 0x17,

        /// <summary>
        /// Leggings, inner layer.
        /// </summary>
        InnerLegs = 0x18,

        /// <summary>
        /// Collane
        /// </summary>
        OuterNeck = 0x1E,
    }
}