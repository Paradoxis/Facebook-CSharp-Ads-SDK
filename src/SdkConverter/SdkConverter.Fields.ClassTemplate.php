<?php
/** Variable declarations for PhpStorm */
/** @var \SdkConverter\Fields\ClassReader $class */
require("SdkConverter.ClassTemplateHeader.php");
?>
namespace FacebookAds.Object
{
    public class <?= $class->getClassName(); ?> : AbstractCrudObjectFields
    {
        <?php foreach($class->getConstants() as $constant => $value): ?>
public const string <?= $constant; ?> = "<?= $value; ?>";
        <?php endforeach; ?>

    }
}


