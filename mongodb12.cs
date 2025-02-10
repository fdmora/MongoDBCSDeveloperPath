atlas setup --clusterName myAtlasClusterEDU --provider AWS --currentIp --skipSampleData --username myAtlasDBUser --password myatlas-001 --projectId 67a6522fd25fa85b32f94b0a    | tee atlas_cluster_details.txt

----
atlas clusters sampleData load myAtlasClusterEDU
