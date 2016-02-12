<?php
/** Variable declarations for PhpStorm */
/** @var \SdkConverter\Object\ClassReader $class */
require("SdkConverter.ClassTemplateHeader.php"); ?>

namespace FacebookAds.Object
{
    public class <?= $class->getClassName(); ?> : AbstractCrudObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdAccount"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="parentId">The parent identifier.</param>
        /// <param name="client">The client.</param>
        public <?= $class->getClassName(); ?>(string id, string parentId = null, FacebookClient client = null) : base(id, parentId, client) { }

        /// <summary>Gets the endpoint of the API call.</summary>
        /// <returns>Endpoint URL</returns>
        protected override string GetEndpoint()
        {
            return "<?= $class->getEndPoint(); ?>";
        }
        <?php foreach($class->getMethods() as $method): ?>

        /// <summary>
        /// <?= $method->getDocumentation(); ?>.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        <?php if ($method->getType() == \SdkConverter\Object\MethodReader::TYPE_DIRECT): ?>
public object <?= $method->getMethodName(); ?>(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.<?= $method->getConnectionMethod(); ?>("<?= $method->getApiEndPoint(); ?>", fields, parameters);
        }
        <?php endif; ?><?php if ($method->getType() == \SdkConverter\Object\MethodReader::TYPE_REFLECTION): ?>
public object <?= $method->getMethodName(); ?>(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.<?= $method->getConnectionMethod(); ?>(typeof(<?= $method->getReflectionClassType(); ?>), fields, parameters);
        }
        <?php endif; ?>
        <?php endforeach; ?>

    }
}


